using System;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Concrete.item
{
    public class PheromonesFactory : AbstractItemFactory
    {
        public PheromonesFactory()
        {
        }

        public override AbstractItem createItem()
        {
            return CreateItemWithType(PheromonesItem.NEUTRAL);
        }

        public AbstractItem CreateItemWithType(String type){
			PheromonesItem pheromone = new PheromonesItem();
            pheromone.Type = type;
            pheromone.turnDuration = PheromonesItem.DURATION;
			return pheromone;
        }
    }
}
