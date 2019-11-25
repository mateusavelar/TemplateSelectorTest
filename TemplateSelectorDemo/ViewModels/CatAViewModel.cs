using System;

namespace TemplateSelectorDemo.ViewModels
{
    public class CatAViewModel : ViewModelBase, IDinamicViewModel

    {
        public ViewModelType VmType { get; set; }

        public CatAViewModel()
        {
            SomeText = $"Some Cat ^.^ Date:{DateTime.Now}";
            VmType = ViewModelType.CatA;
        }

        private string _SomeText;

        public string SomeText
        {
            get { return _SomeText; }
            set
            {
                _SomeText = value;
                NotifyPropertyChanged();
            }
        }
    }
}