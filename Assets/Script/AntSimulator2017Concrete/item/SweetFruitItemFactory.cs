using System;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Concrete.item
{
    public class SweetFruitItemFactory : AbstractItemFactory
    {
        public SweetFruitItemFactory()
        {
        }

        public override AbstractItem createItem()
        {
            SweetFruitItem item = new SweetFruitItem();
            item.FeedingValue = 10;
            item.Portion = 999;
            return item;
        }
    }
}
