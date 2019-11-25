using System;

namespace TemplateSelectorDemo.ViewModels
{
    public class CatBViewModel : ViewModelBase, IDinamicViewModel
    {
        public ViewModelType VmType { get; set; }

        public CatBViewModel()
        {
            SomeMessage = $"Some Cat ||| Date:{DateTime.Now}";
            VmType = ViewModelType.CatB;
        }

        private string _SomeMessage;

        public string SomeMessage
        {
            get { return _SomeMessage; }
            set
            {
                _SomeMessage = value;
                NotifyPropertyChanged();
            }
        }
    }
}