using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Model
{
    public class ToDo
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDate { get; set; }
        public string Person { get; set; }

        public static List<ToDo> ToDoList = new List<ToDo>
        {
            new ToDo() {Id = 1, TaskName = "Vaske", TaskDate = "20.03.2021", Person = "Tobias"},
            new ToDo() {Id = 2, TaskName = "lage", TaskDate = "20.04.2021", Person = "Pål"},
            new ToDo() {Id = 3, TaskName = "Klippe gress", TaskDate = "Mandag", Person = "Per"},
            new ToDo() {Id = 4, TaskName = "rydde", TaskDate = "Tirsdag", Person = "Olsen"},
            new ToDo() {Id = 5, TaskName = "handle", TaskDate = "Torsdag", Person = "Ola"},
            new ToDo() {Id = 6, TaskName = "sove", TaskDate = "Fredag", Person = "Askeladen"}
        };


        public static ToDo AddToDoTask(ToDo task)
        {
            ToDoList.Add(task);
            return task;
        }
    }
}
