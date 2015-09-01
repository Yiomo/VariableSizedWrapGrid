using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VariableSizedWrapGrid
{
    public class VariableGridView : GridView
    {
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            var viewModel = item as IResizable;
            if (viewModel != null)
            {
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, viewModel.RowSpan);
            }

            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
