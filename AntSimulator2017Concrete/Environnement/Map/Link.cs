using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class Link : AbstractLink
    {
        public override void MoveTrough(AntSimulator2017Abstract.Character.Character charac)
        {
            if(Area1.Position.Equals(charac.position)){
                charac.position.x = Area2.Position.x;
				charac.position.y = Area2.Position.y;

			}else{
                charac.position.x = Area1.Position.x;
				charac.position.y = Area1.Position.y;
			}
        }
    }
}
