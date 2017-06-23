using System;
namespace AntSimulator2017Concrete.item
{
    public class EggItem
    {
        static int BASEDURATION = 10;
        public int EclosionTime { get; set; }


        public EggItem(){
            EclosionTime = EggItem.BASEDURATION;
        }

        public EggItem(int eclosionTime)
        {
            EclosionTime = eclosionTime;
        }
    }
}
