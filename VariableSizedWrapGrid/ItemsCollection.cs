using System.Collections.ObjectModel;

namespace VariableSizedWrapGrid
{
    public class ItemsCollection : ObservableCollection<Item>
    {
        public ItemsCollection()
        {
            Refresh();
        }

        public void Refresh()
        {
            Clear();

            for (var i = 1; i <= 20; i++)
            {
                Items.Add(new Item { Index = i });
            }
        }
    }
}
