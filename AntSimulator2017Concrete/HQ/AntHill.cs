using System;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Concrete.Character;

namespace AntSimulator2017Concrete.HQ
{
    public class AntHill : AbstractHeadQuarter
    {

        public Queen queen { get; set; }

        public AntHill()
        {
        }

        public override void update(object data)
        {
            throw new NotImplementedException();
        }

        public override void notify()
        {
            throw new NotImplementedException();
        }
    }
}
