namespace MyMVVM.DataTransfer
{
    /// <summary>
    /// Singleton, stores data for transfer between ViewModels
    /// </summary>
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
            }
            return instance;
        }

        /// <summary>
        /// Cheking for up-to-date data
        /// </summary>
        private bool _needToDelete = false;

        /// <summary>
        /// Message with data for ViewModel
        /// </summary>
        private DataMessage _dataMessage;

        /// <summary>
        /// Receiving data message
        /// </summary>
        /// <returns></returns>
        public DataMessage GetDataMessage()
        {
            _needToDelete = true;
            return _dataMessage;
        }

        /// <summary>
        /// Sending data message
        /// </summary>
        /// <param name="dataMessage"></param>
        public void SendDataMessage(DataMessage dataMessage)
        {
            _needToDelete = false;
            _dataMessage = dataMessage;
        }

    }
}
