using System;
using AntSimulator2017Abstract.Item;
namespace AntSimulator2017Concrete.item
{
    public abstract class FruitItem : AbstractItem
    {
        public abstract int portion { get; set; }
        public FruitItem()
        {
        }
    }
}
