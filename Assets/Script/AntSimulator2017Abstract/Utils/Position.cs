using System;
namespace AntSimulator2017Abstract
{
    public class Position
    {
        private Position position;

        public int x { get; set; }
		public int y { get; set; }

		public override bool Equals(object obj)
		{
            var myObj = obj as Position;
            if(x == myObj.x && y == myObj.y){
                return true;
            }
            return false;
		}

        public Position(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position(Position pos)
		{
			this.x = pos.x;
			this.y = pos.y;
		}

    }
}
