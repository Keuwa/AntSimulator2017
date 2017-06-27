using System;
namespace AntSimulator2017Abstract.Item
{
    public abstract class AbstractItem
    {

        public string name { get; set; }
        public int turnDuration { get; set; }
        public Position position { get; set; }

    }
}
