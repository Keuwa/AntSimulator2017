using System;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission.step
{
    public class BringBackItem : AbstractStep
    {
        public BringBackItem()
        {
        }

        public override string name => "Apporte la nourriture à la fourmiliére";
    }
}
