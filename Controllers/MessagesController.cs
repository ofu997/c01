using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCwithAuth.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace MVCwithAuth.Controllers
{
    [Route("Archives/[action]")]
    public class MessagesController : Controller
    {
        private readonly MVCwithAuthContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public List<String> AdminEmails = new List<String>{"nellstrand@luc.edu", "nathanellstrand@gmail.com", "ofu997@gmail.com"};
        public MessagesController(MVCwithAuthContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Messages
        public async Task<IActionResult> Index(string searchString)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var messages = from m in _context.Message
                select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                messages = messages.Where(
                    s => s.Author.Contains(searchString)
                    ||s.Title.Contains(searchString)
                    ||s.City.Contains(searchString)
                    ||s.Publisher.Contains(searchString)
                    ||s.Year.Contains(searchString)
                    ||s.Tags.Contains(searchString)
                    ||s.Content.Contains(searchString)
                );
            }

            if (currentUser == null) 
            {
                ViewData["Message"] = "Anonymous viewing";
                return View(await messages.OrderByDescending(x => x.TimeStamp).ToListAsync());
            }
                Console.WriteLine("there is a user");
                return View(await messages.OrderByDescending(x => x.TimeStamp).ToListAsync());        
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound("this archive doesn't exist");
            }

            var message = await _context.Message
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound("there are no archives");
            }

            return View(message);
        }

        // GET: Messages/Create
        public async Task<IActionResult> Create()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                return NotFound("You need to be logged in");
            }

            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Author,Title,City,Publisher,Year,Tags,Content,TimeStamp,userEmail")] Message message)
        {   
            var currentUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid && currentUser != null)
            {
                message.userEmail = currentUser.Email;
                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else if (ModelState.IsValid && currentUser == null)
            {
                return NotFound("You need to be logged in");
            }
            else if (!ModelState.IsValid)
            {
                return NotFound("Submission error");
            }
            
            return View(message);
        }

        // GET: Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("this identification number for this archive doesn't exist");
            }

            var currentUser = await _userManager.GetUserAsync(User);

            var message = await _context.Message.FindAsync(id);
                // Console.WriteLine("message.userEmail: {0}, currentUser.Email: {1}",message.userEmail, currentUser.Email);
            if (message == null)
            {
                return NotFound("archive not found");
            }
            // change currentUser.Email to currentUser
            if (currentUser == null)
            {
                return NotFound("You need to be logged in to edit archives");
            }
            if(currentUser.Email != message.userEmail && AdminEmails.Contains(currentUser.Email) == false)
            {
                Console.WriteLine("message.userEmail: {0}, currentUser.Email: {1}", message.userEmail, currentUser.Email);
                return NotFound("Admin only: you are not authorized to edit this archive");
            }

            return View(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,Title,City,Publisher,Year,Tags,Content,TimeStamp,userEmail")] Message message)
        {
            if (id != message.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(message);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessageExists(message.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(message);
        }

        // GET: Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound("this archive doesn't exist");
            }

            var message = await _context.Message
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound("there is no archive");
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("You need to be logged in to delete this archive");
            }
            if (currentUser.Email != message.userEmail && AdminEmails.Contains(currentUser.Email)==false)
            {
                return NotFound("You are not authorized to delete this source");
            }

            return View(message);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = await _context.Message.FindAsync(id);
            _context.Message.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessageExists(int id)
        {
            return _context.Message.Any(e => e.Id == id);
        }
    }
}