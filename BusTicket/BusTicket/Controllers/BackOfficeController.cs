using System.Linq;
using BusTicket.Models;
using BusTicket.Models.User;
using DataLibrary;
using DataLibrary.Interface;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusTicket.Controllers
{
    public class BackofficeController : Controller
    {
        private IUser _IUser;
        private DataContext _context;
        public BackofficeController(IUser IUsers, DataContext context)
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
            return View(ListingModel);

        }
      

        [HttpGet]
        public ActionResult _userListing()
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
            return PartialView(ListingModel);
        }
            
        public ActionResult _saveAccount()
        {       
            return PartialView();
        }

        [HttpPost]
        public ActionResult _saveAccount(UserIndexListingModel model)
        {
            var acc = new TbUser();          
            acc.FirstName = model.FirstName;
            acc.LastName = model.LastName;
            acc.Email = model.Email;
            acc.Username = model.Username;
            acc.Password = model.Password;
            acc.Status = model.Status;
            acc.UserType = model.UserType;
            acc.AuthoriseLevel = model.AuthoriseLevel;
            _IUser.AddUser(acc);
            return Json("User is added");
        }

        public ActionResult _editAccount(int AccId)
        {
            var AccountById = _IUser.GetById(AccId);
            var model = new UserDetailModel
            {
                Id = AccId,
                FirstName = AccountById.FirstName,
                LastName = AccountById.LastName,
                Username = AccountById.Username,
                Password = AccountById.Password,
                Status = AccountById.Status,
                Email= AccountById.Email,
                AuthoriseLevel = AccountById.AuthoriseLevel

            };
            
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult _GetUserById(int UserID)
        {
            var tbUser = new TbUser();
            
            _IUser.EditUser(tbUser);
            return View();
        }
        public ActionResult GetUserList()
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
            return PartialView(ListingModel);
        }
    }
}
