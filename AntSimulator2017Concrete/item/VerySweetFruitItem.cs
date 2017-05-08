using System;
namespace AntSimulator2017Concrete.item
{
    public class VerySweetFruitItem : FruitItem
    {
        public VerySweetFruitItem()
        {
        }

        public override int portion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string name => "Fruit very sweet";
    }
}
