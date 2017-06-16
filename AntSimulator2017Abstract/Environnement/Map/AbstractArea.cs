using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Abstract.Environnement.Map
{
    public class AbstractArea
    {
        public List<AbstractLink> Links { get; set; }
		public List<AbstractItem> Fruits { get; set; }
		public Position Position { get; set; }
        public int usedSpace { get; set; }
        public int Space { get; set; }

        public override bool Equals(object obj)
        {
            var myObj = obj as AbstractArea;
            return Position.Equals(myObj.Position);
        }
        public Boolean IsAccessible(){
            return usedSpace == Space ? false:true;
        }
        public void AddAnt(){
            usedSpace++;
        }
        public void RemoveAnt(){
            if(usedSpace == 0){
                usedSpace = 0;
            }else{
                usedSpace--;
            }
        }
    }
}
