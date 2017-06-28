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
            area.Fruits = new List<AntSimulator2017Abstract.Item.AbstractItem>();
            area.Pheromones = new List<item.PheromonesItem>();
            area.Space = 2;
            area.Links = new List<AbstractLink>();
            return area;
        }
    }
}
