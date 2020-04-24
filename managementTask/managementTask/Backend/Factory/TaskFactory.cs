using managementTask.Backend.TaskLibrary;
using managementTask.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace managementTask.Factory
{
    public sealed class TaskFactory
    {
        //Factory class that is used to create Tasks, sync with SQL_DB
        //TaskCollection used to store tasks locally.
        //Has to sync with SQL_DB once in a while
        //Singleton
        //multi-thread safe becos of lock
        private static TaskFactory instance = null;
        private static readonly object padlock = new object();
        private TaskLibrary _taskLibrary = new TaskLibrary();

        public TaskFactory()
        {
            //constructor for the factory
        }

        public static TaskFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TaskFactory();
                    }
                    return instance;
                }
            }
        }


        private bool SyncTask()
        {
            //syncs one task with the SQL_DB
            //this is private and will be called at the end of every
            //other method in this class
            //must send signal to redraw the task in UI
            throw new NotImplementedException();
        }

        public bool SyncTaskCollection()
        {
            //syncs the whole TaskCollection with the SQL_DB
            //adds new tasks to DB
            //deletes old tasks from DB
            //updates tasks from DB
            //shows conflicts to user?
            //must send signal to redraw the tasks in UI
            throw new NotImplementedException();
        }

        public IEnumerator<List<Task>> GetTaskCollectionIterator()
        {
            
            throw new NotImplementedException();
        }

        public bool FetchTasks()
        {
            //fetch tasks from SQL_DB and update the task collection
            throw new NotImplementedException();
        }

        public bool CreateTask(Task task)
        {
            //creates new Task using Task object, adds to taskLibrary, then syncs taskLibrary with SQL_DB
            throw new NotImplementedException();
        }
        
        public bool DeleteTask(int taskID)
        {
            //deletes the Task identified by ID locally and remotely
            throw new NotImplementedException();
        }

        public bool UpdateTask(Task task)
        {
            //updates the Task
            //how? create a new task and delete the old one?
            throw new NotImplementedException();
        }

    }
}
