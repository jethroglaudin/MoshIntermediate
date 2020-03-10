using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Logger
    {
        public void Log(String message)
        {
            Console.WriteLine(message);
        }
    }
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

    public class UploadVideo : Logger, IInitTask
    {
        private string _message = "Uploading User's Video";

        public void Execute()
        {
            Log(_message);
        }
    }

    public class WebService : Logger, IInitTask
    {
        private string _message = "Calling Web service to encode user's video....";

        public void Execute()
        {
            Log(_message);
        }
    }

    public class Email : Logger, IInitTask
    {
        private string _message = "Sending confirmation email....";

        public void Execute()
        {
            Log(_message);
        }
    }

    public class ChangeStatus : Logger, IInitTask
    {
        private string _message = "Status changed to processing....";

        public void Execute()
        {
            Log(_message);
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
