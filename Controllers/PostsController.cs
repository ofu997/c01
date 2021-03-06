using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCwithAuth.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MVCwithAuth.Controllers
{
    public class PostsController : Controller
    {
        private readonly MVCwithAuthContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public List<String> AdminEmails = new List<String>{"nellstrand@luc.edu", "nathanellstrand@gmail.com", "ofu997@gmail.com", "fu.serena@gmail.com "};
        public PostsController(MVCwithAuthContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Posts
        public async Task<IActionResult> Index(IFormFile file)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null) 
            {
                ViewData["Message"] = "Anonymous viewing";
            }
                Console.WriteLine("there is a user");            
            return View(await _context.Post.OrderByDescending(x => x.TimeStamp).ToListAsync());
        }

        // GET: Posts/Details/5
        // [Route("Posts/[action]/[Title]")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound("this post doesn't exist");
            }

            var post = await _context.Post
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound("this post doesn't exist");
            }

            return View(post);
        }

        // GET: Posts/Create
        public async Task<IActionResult> Create()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                return NotFound("You need to be logged in");
            }

            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,TimeStamp,userEmail")] Post post)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid && currentUser != null)
            {
                post.userEmail = currentUser.Email;
                _context.Add(post);
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
                Console.WriteLine("Post Create: currentUser.Email: {0}. post.userEmail: {1}", currentUser.Email, post.userEmail);

            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("this post doesn't exist");
            }

            var currentUser = await _userManager.GetUserAsync(User);

            var post = await _context.Post.FindAsync(id);
                // Console.WriteLine("post.userEmail: {0}, currentUser.Email: {1}", post.userEmail, currentUser.Email);
            if(post == null)
            {
                return NotFound("This post doesn't exist");
            }
            // change currentUser.email to currentuser
            if (currentUser == null)
            {
                return NotFound("You need to be logged in to edit posts");
            }
            if (post.userEmail != currentUser.Email && AdminEmails.Contains(currentUser.Email) == false)
            {
                Console.WriteLine("post.userEmail: {0}, currentUser.Email: {1}", post.userEmail, currentUser.Email);
                return NotFound("You are not authorized to edit this post"); 
            }

            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,TimeStamp,userEmail")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
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
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound("this post doesn't exist");
            }

            var post = await _context.Post
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound("there is no post");
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("you need to be logged in");
            }
            if (currentUser.Email != post.userEmail && AdminEmails.Contains(currentUser.Email) == false)
            {
                Console.WriteLine("currentUser.Email: {0}. post.userEmail: {1}", currentUser.Email, post.userEmail);
                return NotFound("You are not authorized to delete this post");
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Post.FindAsync(id);
            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
