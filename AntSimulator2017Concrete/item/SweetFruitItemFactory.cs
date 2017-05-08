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
            return new SweetFruitItem();
        }
    }
}
