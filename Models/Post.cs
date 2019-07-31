using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MVCwithAuth.Models
{
    public class Post
    {
        public IdentityUser currentUser {get;set;}

        private readonly MVCwithAuthContext _context;


        // private readonly IHttpContextAccessor _hCA;
        //  = await UserManager<IdentityUser>.GetUserAsync(User);
        private readonly UserManager<IdentityUser> _userManager;
        private readonly Microsoft.AspNetCore.Identity.ClaimsIdentityOptions.IHttpContextAccessor.getCurrentUser currentUser;
        public int Id { get; set; }
        public string OwnerId {get;set;}
        public string Title { get; set; }
        public string Content { get; set; }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy h:mm tt}")]
        public DateTime TimeStamp { get; set; } 

        public Post()
        {
            TimeStamp = DateTime.Now;
            OwnerId = IdentityUserLogin();
        }
        // public Post(UserManager<IdentityUser> userManager, IdentityUser currentUser, MVCwithAuthContext context)
        // {
        //     _context = context;
        //     _userManager = userManager;
        //     TimeStamp = DateTime.Now;
        //     context.Find.OwnerId= currentUser;

        //     async Task getCurrentUser()
        //     {
        //         await _userManager.GetUserAsync(User);
        //     }
        //     // var currentUser = _userManager.GetUserAsync(GetUser.User);     
        //     var currentUser = _userManager.GetEmailAsync(User);   
        //     // public virtual System.Threading.Tasks.Task<string> GetEmailAsync (TUser currentUser);              

        // }

        // public async GetUser()
        // {
        //     private
        // }        
    }
}