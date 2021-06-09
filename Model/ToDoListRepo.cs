

using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace ToDoAPI.Model
{
    public static class TodoListRepo
    {

        public static string[][] TaskList => new string[][]
        {
            new string[] {"Vaske", "20.03.2021", "Tobias"}, 
            new string[] {"lage", "20.04.2021", "Pål"}, 
            new string[] {"Klippe gress", "Mandag", "Per"}, 
            new string[] {"rydde", "Tirsdag", "Olsen"}, 
            new string[] {"handle", "Torsdag", "Ola"}, 
            new string[] {"sove", "Fredag", "Askeladen"}
        };
    }
}