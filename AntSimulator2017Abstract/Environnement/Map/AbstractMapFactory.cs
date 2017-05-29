using System;
using System.Collections.Generic;
namespace AntSimulator2017Abstract.Environnement.Map
{
    public abstract class AbstractMapFactory
    {
        public abstract AbstractMap createMap(int height,int width);
    }
}
