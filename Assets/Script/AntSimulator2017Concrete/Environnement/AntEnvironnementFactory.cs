using System;
using AntSimulator2017Abstract.Environnement;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Abstract;

namespace AntSimulator2017Concrete.Environnement
{
    public class AntEnvironnementFactory:AbstractEnvironnementFactory
    {
        public override AbstractEnvironnement createEnvironnement(int mapHeight,int mapWidth)
        {
            Random rand = new Random();
            AntEnvironnement environnement = new AntEnvironnement();
            environnement.Map  = new MapFactory().createMap(mapHeight,mapWidth) ;
            environnement.HeadQuarters = new System.Collections.Generic.List<AntSimulator2017Abstract.HQ.AbstractHeadQuarter>();
            environnement.HeadQuarters.Add(new AntHillFactory().createHQ(new Position(rand.Next(1,mapHeight-2),rand.Next(1, mapWidth - 2))));
            return environnement;
        }
    }
}
