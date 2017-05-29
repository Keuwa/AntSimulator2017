using System;
namespace AntSimulator2017Abstract.Environnement
{
    public abstract class AbstractEnvironnementFactory
    {
        public abstract AbstractEnvironnement createEnvironnement(int mapHeight,int mapWidth);
    }
}
