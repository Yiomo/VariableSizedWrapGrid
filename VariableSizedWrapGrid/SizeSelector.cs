using VariableSizedWrapGrid.Controls;

namespace VariableSizedWrapGrid
{
    public class SizeSelector : VariableGridSizeSelector
    {
        public override int GetRowSpan(object item)
        {
            return ((Item)item).RowSpan;
        }
    }
}
