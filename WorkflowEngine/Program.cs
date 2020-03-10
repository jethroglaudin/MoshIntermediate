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

    public class UploadVideo : IInitTask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading user's video....");
        }
    }

    public class WebService : IInitTask
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web service to encode user's video....");
        }
    }

    public class Email : IInitTask
    {
        public void Execute()
        {
            Console.WriteLine("Sending confirmation email....");
        }
    }

    public class ChangeStatus : IInitTask
    {
        public void Execute()
        {
            Console.WriteLine("Status changed to processing....");
        }
    }


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

   public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (IInitTask operation in workflow.GetTasks())
            {
                operation.Execute();
            }
    
        }
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
