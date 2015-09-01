using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VariableSizedWrapGrid
{
    public sealed partial class MainPage : Page
    {
        private readonly Random random = new Random();

        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>();
            RefreshItems();
        }

        public ObservableCollection<Item> Items { get; }

        private void RefreshItems()
        {
            var items = Enumerable.Range(0, 10)
                .Select(x => new Item
                {
                    Index = x + 1,
                    RowSpan = random.Next(3) + 1
                });
            Items.Clear();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            RefreshItems();
        }
    }
}
