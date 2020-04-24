using managementTask.Backend.Task;
using managementTask.Backend.TaskAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace managementTask.Task
{ 
    class Task
    {
        private List<TaskAttribute> _attributes = new List<TaskAttribute>();
        //Task class used to make Task objects from SQL_DB
        public Task(/*params*/)
        {
            //Task constructor usedi n create task
            //should get input stream from SQL as input
        }

        //methods for update task and delete task to be implemented
    }
}
