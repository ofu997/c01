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
        // private readonly SignInManager<IdentityUser> _signInManager;
        // public MessagesController(MVCwithAuthContext context)
        // {
        //     _context = context;
        // }


        public MessagesController(MVCwithAuthContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Messages
        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchString)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var messages = from m in _context.Message
                select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                messages = messages.Where(s => s.Title.Contains(searchString));
            }

            if (currentUser == null) {
                // message = "anonymous";
                ViewData["Message"] = "Anonymous viewing";
                // return Challenge();
                return View(await messages.ToListAsync());
            }
                Console.WriteLine("there is a user");
                // string [] tempEmailArray = Split("@");
                // string userName = tempEmailArray[0];
                // ViewData["UserName"] = userName; 
            return View(await messages.ToListAsync());
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Tags,Content,TimeStamp, userEmail")] Message message)
        {   
            var currentUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid && currentUser != null)
            {
                message.userEmail = currentUser.Email;
                _context.Add(message);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                Console.WriteLine("message.userEmail: {0}",message.userEmail);
            return View(message);
        }

        // GET: Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("this archive doesn't exist");
            }

            var currentUser = await _userManager.GetUserAsync(User);

            var message = await _context.Message.FindAsync(id);
                // message.userEmail is printing null, currentUser.Email prints as expected
                Console.WriteLine("message.userEmail: {0}, currentUser.Email: {1}",message.userEmail, currentUser.Email);
            if (message == null)
            {
                return NotFound("archive not found");
            }

            if(message.userEmail != currentUser.Email)
            {
                return NotFound("you are not authorized to edit this archive");
            }


            return View(message);
        }

        // POST: Messages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Tags,Content,Time")] Message message)
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
                return NotFound("there are no archives");
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
