using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class Link : AbstractLink
    {
        public override bool CanMoveTrough()
        {
            throw new NotImplementedException();
        }

        public override bool IsAreaAccessible(AntSimulator2017Abstract.Position posFrom)
        {
            if(Area1.Position == posFrom){
                return Area2.IsAccessible();
            }
			return Area1.IsAccessible();
			
        }

        public override void MoveTrough(AntSimulator2017Abstract.Character.Character charac)
        {
            if(Area1.Position.Equals(charac.position)){
				Area1.RemoveAnt();
				Area2.AddAnt();
                charac.position.x = Area2.Position.x;
				charac.position.y = Area2.Position.y;
			}else{
				Area2.RemoveAnt();
				Area1.AddAnt();
                charac.position.x = Area1.Position.x;
				charac.position.y = Area1.Position.y;
			}
        }
    }
}
