using System;
namespace AntSimulator2017Abstract.Item
{
    public abstract class AbstractItemFactory
    {
        public AbstractItemFactory()
        {
        }

        public abstract AbstractItem createItem();
    }
}
