using System;
using AntSimulator2017Abstract.Character;

namespace AntSimulator2017Abstract.Environnement.Map
{
    public abstract class AbstractLink
    {
        public AbstractArea Area1 { get; set; }
        public AbstractArea Area2 { get; set; }
        public Boolean IsOpen { get; set; }

        public abstract void MoveTrough(Character.Character charac);
        public abstract Boolean CanMoveTrough();
        public abstract bool IsAreaAccessible(Position pos);

        public AbstractArea GetArrivalArea(AbstractArea AreaFrom){
            if(AreaFrom.Equals(Area1)){
                return Area2;
            }
            return Area1;
        }

        public bool IsCloserTo(AbstractArea currentArea, Position finalPosition)
        {
            var testedArea = GetArrivalArea(currentArea);

            var testedPosition = testedArea.Position;
            var curentPosition = currentArea.Position;
            var xResultTested = Math.Abs(testedArea.Position.x - finalPosition.x);
            var xResultCurent = Math.Abs(currentArea.Position.x - finalPosition.x);
			var yResultTested = Math.Abs(testedArea.Position.y - finalPosition.y);
			var yResultCurent = Math.Abs(currentArea.Position.y - finalPosition.y);


            var a = Math.Abs(testedArea.Position.x - finalPosition.x) <= Math.Abs(currentArea.Position.x - finalPosition.x);
            var b = Math.Abs(testedArea.Position.y - finalPosition.y) <= Math.Abs(currentArea.Position.y - finalPosition.y);

            if(Math.Abs(testedArea.Position.x-finalPosition.x) <= Math.Abs(currentArea.Position.x-finalPosition.x) 
               && Math.Abs(testedArea.Position.y - finalPosition.y) <= Math.Abs(currentArea.Position.y - finalPosition.y) ){
                return true;
            }
            return false;
        }
    }
}
