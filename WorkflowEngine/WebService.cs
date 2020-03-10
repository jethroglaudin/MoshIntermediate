namespace WorkflowEngine
{
    public class WebService : Logger, IInitTask
    {
        private string _message = "Calling Web service to encode user's video....";

        public void Execute()
        {
            Log(_message);
        }
    }
}
