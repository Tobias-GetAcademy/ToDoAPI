﻿using System.Collections.Generic;

namespace ToDoAPI.Model
{
    public class TodoList : List<ToDo>
    {
        public TodoList()
        {
            this.AddRange(new[]{
                new ToDo() {Id = 1, TaskName = "Vaske", TaskDate = "20.03.2021", Person = "Tobias"},
                new ToDo() {Id = 2, TaskName = "lage", TaskDate = "20.04.2021", Person = "Pål"},
                new ToDo() {Id = 3, TaskName = "Klippe gress", TaskDate = "Mandag", Person = "Per"},
                new ToDo() {Id = 4, TaskName = "rydde", TaskDate = "Tirsdag", Person = "Olsen"},
                new ToDo() {Id = 5, TaskName = "handle", TaskDate = "Torsdag", Person = "Ola"},
                new ToDo() {Id = 6, TaskName = "sove", TaskDate = "Fredag", Person = "Askeladen"}
            });
        }
    }
}