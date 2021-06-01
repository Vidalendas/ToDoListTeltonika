using System.Collections.Generic;
using TODO_list.Models;

namespace ToDoListTeltonika.Data
{
    public interface IToDoListRepo
    {
        bool SaveChanges();
        IEnumerable<Task> GetUserTasks();
        Task GetTaskByUserId(int userId);
        void CreateTask(Task tsk);
        Task GetTaskById(int id);
        void DeleteTask(Task tsk);
        void UpdateTask(Task tsk);

    }
}
