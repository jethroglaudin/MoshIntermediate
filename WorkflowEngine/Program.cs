using System;

namespace WorkflowEngine
{
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
