using System;

namespace ToDoListTeltonika.Data
{
    public interface IUsersRepo
    {
        Boolean GetUserCredByEmail(string email, string password);
        void DeleteAllUserData();
    }
}
