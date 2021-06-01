using System;
using System.Collections.Generic;
using System.Linq;
using TODO_list.Data;
using TODO_list.Models;

namespace ToDoListTeltonika.Data
{
    public class SqlToDoListRepo : IToDoListRepo
    {
        private readonly ToDoContext _context;
        public SqlToDoListRepo(ToDoContext context)
        {
            _context = context;
        }
        public void CreateTask(Task tsk)
        {
            if (tsk == null)
            {
                throw new ArgumentNullException(nameof(tsk));
            }
            _context.Tasks.Add(tsk);
        }

        public void DeleteTask(Task tsk)
        {
            if (tsk == null)
            {
                throw new ArgumentNullException(nameof(tsk));
            }
            _context.Tasks.Remove(tsk);
        }

        public Task GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Task> GetTaskByUserId(int userId)
        {
            return _context.Tasks.ToList();
        }

        public IEnumerable<Task> GetUserTasks()
        {
            return _context.Tasks.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTask(Task tsk)
        {
            
        }

        Task IToDoListRepo.GetTaskByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
