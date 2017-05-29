using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class AreaFactory:AbstractAreaFactory
    {
        public override AbstractArea createArea()
        {
            Area area = new Area();
            area.space = 2;
            area.links = new List<AbstractLink>();
            return area;
        }
    }
}
