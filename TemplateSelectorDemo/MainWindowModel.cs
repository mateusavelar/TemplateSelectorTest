using System.Windows.Input;
using TemplateSelectorDemo.ViewModels;

namespace TemplateSelectorDemo
{
    public class MainWindowModel : ViewModelBase
    {
        public MainWindowModel()
        {
            ShowMenuItem1 = new RelayCommand(DoOnShowMenuItem1);
            ShowMenuItem2 = new RelayCommand(DoOnShowMenuItem2);
        }

        private void DoOnShowMenuItem1() => CurrentViewModel = new CatAViewModel();

        private void DoOnShowMenuItem2() => CurrentViewModel = new CatBViewModel();

        public ICommand ShowMenuItem1 { get; private set; }
        public ICommand ShowMenuItem2 { get; private set; }

        private IDinamicViewModel _currentViewModel;

        public IDinamicViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                NotifyPropertyChanged();
            }
        }
    }
}