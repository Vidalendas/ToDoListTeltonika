using AutoMapper;
using TODO_list.Dtos;
using TODO_list.Models;

namespace TODO_list.Profiles
{
    public class TasksProfile : Profile
    {
        public TasksProfile()
        {
            CreateMap<Task, TaskReadDto>();
            CreateMap<TaskCreateDto, Task>();
            CreateMap<TaskUpdateDto, Task>();
        }
    }
}
