using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IInitTask> _tasks;


        public WorkFlow()
        {
            _tasks = new List<IInitTask>();
        }

        public void Add(IInitTask task)
        {
            _tasks.Add(task);
        }

        public void Remove(IInitTask task)
        {
            _tasks.Remove(task);
        }
        public IEnumerable<IInitTask> GetTasks()
        {
            return _tasks;
        }

    }
}
