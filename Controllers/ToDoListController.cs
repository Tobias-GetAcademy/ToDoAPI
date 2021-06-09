using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Model;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {

        private TodoList _todoList;

        public ToDoListController(TodoList todoList)
        {
            _todoList = todoList;
        }

        // CRUD - Create Read Update Delete

        [HttpGet("{id}")]
        public async Task<ToDo> GetOne(string id)
        {
            // Where TaskName == "Vaske"
            return await Task.Run(() => _todoList.FirstOrDefault(x => x.Id == id));
        }

        [HttpGet]
        public async Task<IEnumerable<ToDo>> GetMany()
        {
            return await Task.Run(() => _todoList);
        }
        
        [HttpPost]
        public async  Task<int> Create(ToDo toDo)
        {
            _todoList.AddToDoTask(toDo);
            return 1;
        }

        [HttpPut]
        public async Task<int> Edit(ToDo toDo)
        {
            var itemToEdit = await Task.Run(() => _todoList.FirstOrDefault(x => x.Id == toDo.Id));
            
            return 1;
        }

        [HttpDelete]
        public async Task<int> Delete(string[] delete)
        {
            foreach (var item in delete)
            {
                var itemToRemove = _todoList.Single(todoList => todoList.Id == item);
                _todoList.Remove(itemToRemove);
            }
            
            await Task.Run(() => _todoList);
            // finn en bestemt task som har lik id som den du ønsker å slette
            // https://www.c-sharpcorner.com/UploadFile/mahesh/remove-items-from-a-C-Sharp-list/

            
            return 1;
        }
    }
}
