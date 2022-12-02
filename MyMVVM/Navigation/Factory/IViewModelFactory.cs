using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Factory
{
    /// <summary>
    /// The factory for creating specific ViewModel 
    /// </summary>
    /// <typeparam name="T">T must be ViewModel</typeparam>
    public interface IViewModelFactory<T> where T : ViewModel
    {
        /// <summary>
        /// Method for creating specific ViewModel
        /// </summary>
        /// <returns>Specific ViewModel</returns>
        public T CreateViewModel();
    }
}
