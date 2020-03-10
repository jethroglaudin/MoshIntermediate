namespace WorkflowEngine
{
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
}
