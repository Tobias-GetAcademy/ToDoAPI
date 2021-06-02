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
        // CRUD - Create Read Update Delete

        [HttpGet("{id}")]
        public async Task<ToDo> GetOne(int id)
        {
            // Where TaskName == "Vaske"
            return await Task.Run(() => ToDo.ToDoList.FirstOrDefault(x => x.Id == id));
        }

        [HttpGet]
        public async Task<IEnumerable<ToDo>> GetMany()
        {
            return await Task.Run(() => ToDo.ToDoList);
        }
        
        [HttpPost]
        public async Task<int> Create(ToDo toDo)
        {
            ToDo.AddToDoTask(toDo);
            return 1;
        }

        [HttpPut]
        public async Task<int> Edit(ToDo ToDo)
        {
            return await Task.Run(() => 1);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    }
}
