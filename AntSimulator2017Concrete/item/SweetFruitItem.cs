using System;
namespace AntSimulator2017Concrete.item
{
    public class SweetFruitItem : FruitItem
    {
        public SweetFruitItem()
        {
        }

        public override int portion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string name => "sweet fruit";
    }
}
