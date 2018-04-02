using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using DataLibrary;
using DataLibrary.Interface;
using DataLibrary.Models;

namespace ServicesLibrary
{
    public class UserServices : IUser
    {
        private DataContext _context;
        public UserServices(DataContext context)
        {
            _context = context;
        }
        public void AddUser(TbUser NewUser)
        {
            _context.Add(NewUser);
            _context.SaveChanges();
        }

        public bool CheckEmail(string Email)
        {
            var EmailExist = GetAll().FirstOrDefault(User => User.Email == Email);
            if (EmailExist != null)
                return true;
            else return false;
        }

        public bool CheckUserName(string Username)
        {
            var UsernameExist = GetAll().FirstOrDefault(User => User.Username == Username);
            if (UsernameExist != null)
                return true;
            else return false;
        }

        public void DeleteUser(int id)
        {
            var User = new TbUser { Id = id };
            _context.TableUser.Remove(User);
            _context.SaveChanges();
        }

        public void EditUser(TbUser CurUser)
        {
            var User = GetAll().FirstOrDefault(x => x.Id == CurUser.Id);
            if(CurUser.FirstName != null)
                User.FirstName = CurUser.FirstName;
            if(CurUser.LastName != null)
                User.LastName = CurUser.LastName;
            if (CurUser.Status != null)
                User.Status = CurUser.Status;
            if (CurUser.UserType != null)
                User.UserType = CurUser.UserType;
            if (CurUser.AuthoriseLevel != null)
                User.AuthoriseLevel = CurUser.AuthoriseLevel;
            if (CurUser.Email != null)
                User.Email = CurUser.Email;
            if (CurUser.Password != null)
                User.Password = CurUser.Password;
            _context.SaveChanges();
        }

        public IEnumerable<TbUser> GetAll()
        {
            return _context.TableUser;
        }

        public string GetPasswordByEmail(string EmailAddress)
        {
            return GetAll().FirstOrDefault(x => x.Email == EmailAddress).Password;
        }

        public TbUser LoginUser(string UserNameOrEmail, string Password)
        {
            if (IsEmail(UserNameOrEmail))
                return GetAll().FirstOrDefault(x => x.Email == UserNameOrEmail && x.Password == Password);
            else
                return GetAll().FirstOrDefault(x => x.Username == UserNameOrEmail && x.Password == Password);
        }
        public bool IsEmail(string UsernameOrEmail)
        {
            try
            {
                var email = new MailAddress(UsernameOrEmail);
                return true;

            }
            catch
            {
                return false;

            }

        }

        public TbUser GetById(int Id)
        {
            return GetAll().FirstOrDefault(x => x.Id == Id);
        }
    }
}
