using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class MapFactory:AbstractMapFactory
    {
        public override AbstractMap createMap(int height,int width){
            Map map = new Map();
            map.areas = new Area[height][];
            for (int i = 0; i < height;i++)
            {
                map.areas[i] = new Area[width];
                for (int j = 0; j < width; j++)
                {
                    map.areas[i][j] = new AreaFactory().createArea();
                    map.areas[i][j].Position = new AntSimulator2017Abstract.Position(i, j);
                    if (i == 0)
                    {
                        if (j != 0)
                        {
                            new LinkFactory().createLink(map.areas[i][j], map.areas[i][j - 1]);
                        }
                    }
                    else
                    {
                        if (j != 0)
                        {
                            new LinkFactory().createLink(map.areas[i][j], map.areas[i][j - 1]);
                        }
                        new LinkFactory().createLink(map.areas[i][j], map.areas[i - 1][j]);
                    }
                }
            }
            return map;
        }


    }
}
