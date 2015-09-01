namespace VariableSizedWrapGrid.Controls
{
    public abstract class VariableGridSizeSelector
    {
        public virtual int GetRowSpan(object item)
        {
            return 1;
        }
    }
}
