﻿using System;
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
    }
}
