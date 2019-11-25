using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TemplateSelectorDemo
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public interface IDinamicViewModel
    {
        ViewModelType VmType { get; set; }
    }

    public enum ViewModelType
    {
        CatA, CatB, Default
    }
}