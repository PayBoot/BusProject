using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusTicket.Models;
using DataLibrary;
using DataLibrary.Interface;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusTicket.Controllers
{
    public class UserController : Controller
    {
        private IUser _IUser;
        private DataContext _context;
        public UserController(IUser IUsers, DataContext context)
        {
            _IUser = IUsers;
            _context = context;
        }

        public IActionResult Index()
        {
            var UserListingModel = _IUser.GetAll();
            var ListingResult = UserListingModel.Select(result => new UserIndexListingModel
            {
                Id = result.Id,
                Username = result.Username,
                Password = result.Password,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                UserType = result.UserType,
                AuthoriseLevel = result.AuthoriseLevel,
                Status = result.Status
            });
            var ListingModel = new UserIndexModel()
            {
                UserListing = ListingResult
            };
            return View();

        }
        public JsonResult GetUserList()
        {
            var UserListingModel = _IUser.GetAll();
            var ListingResult = UserListingModel.Select(result => new UserIndexListingModel
            {
                Id = result.Id,
                Username = result.Username,
                Password =result.Password,
                FirstName = result.FirstName,
                LastName =result.LastName,
                Email =result.Email,
                UserType = result.UserType,
                AuthoriseLevel = result.AuthoriseLevel,
                Status = result.Status
            });
            var ListingModel = new UserIndexModel()
            {
                UserListing = ListingResult
            };
            return new JsonResult(ListingModel);
        }
    }
}
