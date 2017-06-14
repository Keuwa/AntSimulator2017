using System;
using System.Collections.Generic;
namespace AntSimulator2017Abstract.Environnement.Map
{
    public class AbstractArea
    {
        public List<AbstractLink> Links { get; set; }
        public Position Position { get; set; }
        public int Space { get; set; }
        public override bool Equals(object obj)
        {
            var myObj = obj as AbstractArea;
            return Position.Equals(myObj.Position);
        }
    }
}
