using System;
using System.Linq;
using TODO_list.Data;

namespace ToDoListTeltonika.Data
{
    public class SqlUsersRepo : IUsersRepo
    {
        private readonly ToDoContext _context;
        public SqlUsersRepo(ToDoContext context)
        {
            _context = context;
        }
        //Not fully implemented
        public void DeleteAllUserData()
        {
            _context.Users.RemoveRange();
            _context.SaveChanges();
        }

        public Boolean GetUserCredByEmail(string email, string password)
        {
            if (_context.Users.Any(p => p.Email == email && p.Password == password))
            {
                return true;
            }
            else return false;
          
        }
    }
}
