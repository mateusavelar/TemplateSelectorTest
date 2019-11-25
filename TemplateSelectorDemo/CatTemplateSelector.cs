using System.Windows;
using System.Windows.Controls;

namespace TemplateSelectorDemo
{
    public class CatTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TypeATemplate { get; set; }
        public DataTemplate TypeBTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            // Null value can be passed by IDE designer
            if (item == null) return DefaultTemplate;

            IDinamicViewModel model = (IDinamicViewModel)item;

            switch (model.VmType)
            {
                case ViewModelType.CatA:
                    return TypeATemplate;

                case ViewModelType.CatB:
                    return TypeBTemplate;

                default:
                    return DefaultTemplate;
            }
        }
    }
}