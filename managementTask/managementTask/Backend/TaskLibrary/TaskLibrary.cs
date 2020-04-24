using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using managementTask.Backend;

namespace managementTask.Backend.TaskLibrary
{    
    public sealed class TaskLibrary : IEnumerable
    {
        private static TaskLibrary instance = null;
        private static readonly object padlock = new object();
        private List<Task> _taskCollection = new List<Task>();

        public static TaskLibrary Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TaskLibrary();
                    }
                    return instance;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _taskCollection.GetEnumerator();
        }
    }
}
