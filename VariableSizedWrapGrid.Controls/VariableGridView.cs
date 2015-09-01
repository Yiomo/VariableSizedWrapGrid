using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VariableSizedWrapGrid.Controls
{
    public class VariableGridView : GridView
    {
        public VariableGridSizeSelector SizeSelector
        {
            get { return (VariableGridSizeSelector)GetValue(SizeSelectorProperty); }
            set { SetValue(SizeSelectorProperty, value); }
        }

        public static readonly DependencyProperty SizeSelectorProperty =
            DependencyProperty.Register("SizeSelector", typeof(int), typeof(VariableGridView), new PropertyMetadata(null));


        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            if (SizeSelector != null)
            {
                var rowSpan = SizeSelector.GetRowSpan(item);
                element.SetValue(Windows.UI.Xaml.Controls.VariableSizedWrapGrid.RowSpanProperty, rowSpan);
            }

            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
