using Atomas2.Contracts.Items;

namespace Atomas2.Models.Items
{
    public class Item : IItem
    {
        public int Number { get; set; }

        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
