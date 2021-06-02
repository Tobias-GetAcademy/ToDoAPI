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

        public List<ToDo> ToDoList { get; set; } = new List<ToDo>
        {
            new ToDo() {Id = 1, TaskName = "Vaske", TaskDate = "20.03.2021", Person = "Tobias"},
            new ToDo() {Id = 2, TaskName = "lage", TaskDate = "20.04.2021", Person = "Pål"},
            new ToDo() {Id = 3, TaskName = "Klippe gress", TaskDate = "Mandag", Person = "Per"},
            new ToDo() {Id = 4, TaskName = "rydde", TaskDate = "Tirsdag", Person = "Olsen"},
            new ToDo() {Id = 5, TaskName = "handle", TaskDate = "Torsdag", Person = "Ola"},
            new ToDo() {Id = 6, TaskName = "sove", TaskDate = "Fredag", Person = "Askeladen"}
        };

        public ToDoListController(List<ToDo> toDo)
        {
            ToDoList = toDo;
        }

        [HttpGet("{id}")]
        public async Task<ToDo> GetOne(int id)
        {
            // Where TaskName == "Vaske"
            return await Task.Run(() => ToDoList.FirstOrDefault(x => x.Id == id));
        }

        [HttpGet]
        public async Task<IEnumerable<ToDo>> GetMany()
        {
            return await Task.Run(() => ToDoList);
        }
        
        [HttpPost]
        public async Task<int> Create(ToDo toDo)
        {
            ToDoList.Add(toDo);
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
