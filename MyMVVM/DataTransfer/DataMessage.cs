namespace MyMVVM.DataTransfer
{
    public class DataMessage
    {
        public DataMessage(DataMessageArgs args)
        {
            _args = args;
        }

        private readonly DataMessageArgs _args;
        public DataMessageArgs Args
        {
            get => _args;   
        }

        
    }
}
