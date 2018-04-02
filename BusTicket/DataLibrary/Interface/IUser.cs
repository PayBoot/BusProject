using DataLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLibrary.Interface
{
    public interface IUser
    {
        IEnumerable<TbUser> GetAll();
        void AddUser(TbUser NewUser);
        TbUser GetById(int Id);
        void EditUser(TbUser CurUser);
        void DeleteUser(int id);
        TbUser LoginUser(string UserNameOrEmail, string Password);
        bool CheckUserName(string Username);
        bool CheckEmail(string Email);
        string GetPasswordByEmail(string EmailAddress);

    }
}
