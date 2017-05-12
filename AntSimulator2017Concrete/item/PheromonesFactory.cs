using System;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Concrete.item
{
    public class PheromonesFactory : AbstractItemFactory
    {
        public PheromonesFactory()
        {
        }

        public override AbstractItem createItem()
        {
            return new PheromonesItem();
        }
    }
}
