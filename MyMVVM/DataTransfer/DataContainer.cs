namespace MyMVVM.DataTransfer
{
    public class DataContainer
    {
        private DataContainer() { }
        public DataMessage DataMessage { get; set; }

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
