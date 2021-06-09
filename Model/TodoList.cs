using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ToDoAPI.Model
{
    public class TodoList : List<ToDo>
    {

        public List<ToDo> Data;

        public TodoList()
        {
            Data = new List<ToDo>();
            BuildData();
            this.AddRange(Data.ToArray());
        }


        public ToDo AddToDoTask(ToDo task)
        {
            Data.Add(task);
            return task;
        }


        public void BuildData() => TodoListRepo.TaskList.ToList().ForEach(task => Data.Add(BuildToDo(task)));


        public ToDo BuildToDo(string[] current) => new ToDo()
        {
            TaskName = current[0], 
            TaskDate = current[1], 
            Person   = current[2]
        };

    }
}