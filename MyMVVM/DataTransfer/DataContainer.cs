namespace MyMVVM.DataTransfer
{
    public class DataContainer
    {
        private DataContainer()
        {
            if (_needToDelete)
            {
                _dataMessage = null;
            }
        }

        private static DataContainer instance;
        public static DataContainer GetInstance()
        {
            if (instance == null)
            {
                instance = new();
                return instance;
            }
            return instance;
        }

        private bool _needToDelete = false;
        private DataMessage _dataMessage;
        public DataMessage GetDataMessage()
        {
            _needToDelete = true;
            return _dataMessage;
        }
        public void SendDataMessage(DataMessage dataMessage)
        {
            _needToDelete = false;
            _dataMessage = dataMessage;
        }

    }
}
