using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void Add(IInitTask task);
        void Remove(IInitTask task);
        IEnumerable<IInitTask> GetTasks();
    }
}
