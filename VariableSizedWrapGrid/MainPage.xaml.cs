using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VariableSizedWrapGrid
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            Items = new ItemsCollection();
        }

        public ItemsCollection Items { get; }

        private void RefreshItems()
        {
            Items.Refresh();
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshItems();
        }
    }
}
