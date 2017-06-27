using System;
using AntSimulator2017Abstract.Item;
namespace AntSimulator2017Concrete.item
{
    public abstract class FruitItem : AbstractItem
    {
        public int Portion { get; set; }
        public int FeedingValue { get; set; }
	}
}
