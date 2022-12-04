namespace MyMVVM.DataTransfer
{
    public interface IDataMessage
    {
        public IDataMessage GetDataMessage()
        {
            return this;
        }
        public void SendDataMessage();
    }
}
