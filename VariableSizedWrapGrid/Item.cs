using System;

namespace VariableSizedWrapGrid
{
    public class Item
    {
        private static readonly Random random = new Random();

        public Item()
        {
            RowSpan = random.Next(3) + 1;
        }

        public int Index { get; set; }
        public int RowSpan { get; }
    }
}
