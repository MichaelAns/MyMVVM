using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Factory
{
    public interface IViewModelFactory
    {
        public ViewModel GetViewModel(object? parameter);
    }
}
