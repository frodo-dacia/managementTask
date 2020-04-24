using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managementTask.Backend.TaskAttribute
{
    abstract class TaskAttribute
    {
        protected readonly string _value;

        protected TaskAttribute(string i)
        {
            _value = i;
        }

        abstract public string getValue();
    }
}
