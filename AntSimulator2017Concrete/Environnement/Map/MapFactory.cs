using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class MapFactory:AbstractMapFactory
    {
        public  AbstractMap createMap(int height, int width, int numberOfFruit){
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
            int probability;
			Random rand = new Random();

			for (int i = 0; i < numberOfFruit;i++){
				Area area = (Area)map.areas[rand.Next(0, height)][rand.Next(0, height)];
                probability = rand.Next(10);
                if(probability <= 2){
					area.Fruits.Add(new VerySweetItemFactory().createItem());
				}
                else{
					area.Fruits.Add(new SweetFruitItemFactory().createItem());
				}
            }
            return map;
        }

        public override AbstractMap createMap(int height, int width)
        {
           return createMap(height,width,5);
        }
    }
}
