using System;
using AntSimulator2017Abstract.HQ;

namespace AntSimulator2017Concrete.HQ
{
    public class AntHillFactory : AbstractHeadQuarterFactory
    {
        public AntHillFactory()
        {
        }

        public override AbstractHeadQuarter createHQ()
        {
            return new AntHill();
        }
    }
}
