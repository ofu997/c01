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

using MVCwithAuth.ViewModels;
// added
using Microsoft.AspNetCore.Hosting;

namespace MVCwithAuth.Controllers
{
    public class PostsController : Controller
    {
        private readonly MVCwithAuthContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        // added ihostingenvironment
        private readonly IHostingEnvironment ihe;

        // added ihostingenvironment
        public PostsController(MVCwithAuthContext context, UserManager<IdentityUser> userManager, IHostingEnvironment ihe)
        {
            _context = context;
            _userManager = userManager;
            // added
            this.ihe = ihe;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Post.ToListAsync());
        }

        // Change IAR post to index
        [HttpPost("Index")]
        public async Task<IActionResult> Post (List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
                            
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.GetTempFileName();
                    filePaths.Add(filePath);
    
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            // return Ok(new { count = files.Count, size, filePaths });
            return RedirectToAction(nameof(Index));
        }        

        // GET: Posts/Details/5
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
        public IActionResult Create()
        {
            return View();
        }

        // ORIGINAL VERSION
        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Id,Title,Content")] Post post)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(post);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(post);
        // } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        // not using Post model
        // public async Task<IActionResult> Create ([Bind("Id, Title, Content, File")] Post model, List<IFormFile> files)
        public async Task<IActionResult> Create (PostViewModel model)
        
        {
            // ViewData["ReturnUrl"] = returnUrl;
            if  (ModelState.IsValid)
            {
                using (var memoryStream = new MemoryStream())
                {
                    string uniqueFileName = null;
                    if (model.File != null) 
                    {
                        string uploadsFolder = Path.Combine(ihe.WebRootPath, "Files");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                        string pathOfFile = Path.Combine(uploadsFolder, uniqueFileName);
                        model.File.CopyTo(new FileStream(pathOfFile, FileMode.Create));
                    }
                    Post newPost = new Post
                    {
                        Title = model.Title,
                        Content = model.Content,
                        TimeStamp = model.TimeStamp,
                        FilePath = uniqueFileName
                    };
                    // await model.File.CopyToAsync(memoryStream);
                    // model.File = memoryStream.ToArray();
                }


                {
                    _context.Add(model);
                    // this won't work because context can't take newPost? 
                    // _context.Add(newPost);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                };         

            // additional logic omitted

            // Don't rely on or trust the model.AvatarImage.FileName property 
            // without validation.
            }
            return View(model);
        }        

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (id == null)
            {
                return NotFound("this post doesn't exist");
            }

            var post = await _context.Post.FindAsync(id);

            if(post == null || currentUser == null)
            {
                return NotFound("you need to be logged in/this post doesn't exist");
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] Post post)
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
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound("you need to be logged in");
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
