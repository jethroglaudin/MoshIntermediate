using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IInitTask
    {
        void Execute();
    }
    public interface IWorkFlow
    {
        void Add(IInitTask task);
        void Remove(IInitTask task);
        IEnumerable<IInitTask> GetTasks();
    }
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Add(new UploadVideo());
            workFlow.Add(new WebService());
            workFlow.Add(new Email());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);

            Console.ReadLine();
        }
    }
}
