using System;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Concrete.item
{
    public class VerySweetItemFactory : AbstractItemFactory
    {
        public VerySweetItemFactory()
        {
        }

        public override AbstractItem createItem()
        {
            VerySweetFruitItem item = new VerySweetFruitItem();
			item.FeedingValue = 20;
			item.Portion = 999;
			return item;        
        }
    }
}
