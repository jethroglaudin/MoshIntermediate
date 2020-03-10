namespace WorkflowEngine
{
    public class ChangeStatus : Logger, IInitTask
    {
        private string _message = "Status changed to processing....";

        public void Execute()
        {
            Log(_message);
        }
    }
}
