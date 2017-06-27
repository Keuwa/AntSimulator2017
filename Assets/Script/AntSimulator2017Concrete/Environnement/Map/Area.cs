using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Abstract.Item;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class Area:AbstractArea
    {
        public List<PheromonesItem> Pheromones { get; set; }
    }
}
