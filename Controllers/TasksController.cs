using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TODO_list.Dtos;
using TODO_list.Models;
using ToDoListTeltonika.Data;

namespace ToDoListTeltonika.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : Controller
    {
        private readonly IToDoListRepo _repository;
        private readonly IMapper _mapper;
        public TasksController(IToDoListRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        /// <summary>
        /// Gets all user tasks.
        /// </summary>
        //GET api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<TaskReadDto>> GetUserTasks()
        {
            var taskItems = _repository.GetUserTasks();

            return Ok(_mapper.Map<IEnumerable<TaskReadDto>>(taskItems));
        }
        /// <summary>
        /// Gets task by id
        /// </summary>
        //GET api/tasks/{id}
        [HttpGet("{id}", Name = "GetTaskById")]
        public ActionResult<TaskReadDto> GetTaskById(int id)
        {
            var taskItems = _repository.GetTaskById(id);
            if (taskItems != null)
            {
                return Ok(_mapper.Map<TaskReadDto>(taskItems));
            }
            return NotFound();
        }
        /// <summary>
        /// Post a new task
        /// </summary>
        //POST api/tasks
        [HttpPost]
        public ActionResult<TaskReadDto> CreateTask(TaskCreateDto taskCreateDto)
        {
            var taskModel = _mapper.Map<Task>(taskCreateDto);
            _repository.CreateTask(taskModel);
            _repository.SaveChanges();

            var TaskReadDto = _mapper.Map<TaskReadDto>(taskModel);

            return CreatedAtRoute(nameof(GetTaskById), new { Id = TaskReadDto.Id }, TaskReadDto);
        }
        /// <summary>
        /// Updates a task
        /// </summary>
        //PUT api/tasks/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTask(int id, TaskUpdateDto taskUpdateDto)
        {
    
            var taskModelFromRepo = _repository.GetTaskById(id);
            if (taskModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(taskUpdateDto, taskModelFromRepo);

            _repository.UpdateTask(taskModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
        //Delete task api/tasks{id}
        /// <summary>
        /// Delete task
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult DeleteTask(int id)
        {
            var taskModelFromRepo = _repository.GetTaskById(id);
            if(taskModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteTask(taskModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
