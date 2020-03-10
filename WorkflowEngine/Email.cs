namespace WorkflowEngine
{
    public class Email : Logger, IInitTask
    {
        private string _message = "Sending confirmation email....";

        public void Execute()
        {
            Log(_message);
        }
    }
}
