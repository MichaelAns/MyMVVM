namespace MyMVVM.ViewModelBase
{
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModel;
}
