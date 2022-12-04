namespace MyMVVM.DataTransfer
{
    public class DataContainer
    {
        private DataContainer() { }
        private IDataMessage _dataMessage;

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

    }
}
