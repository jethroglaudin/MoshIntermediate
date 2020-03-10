namespace WorkflowEngine
{
    public class UploadVideo : Logger, IInitTask
    {
        private string _message = "Uploading User's Video";

        public void Execute()
        {
            Log(_message);
        }
    }
}
