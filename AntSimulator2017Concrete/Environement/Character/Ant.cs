using System;
using AntSimulator2017Abstract.Environement;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Environement.Character
{
    public class Ant:AntSimulator2017Abstract.Environement.Character
    {
        string State {get; set;}
        public Ant(string name)
        {
            this.Name = name;
        }

       
        public override void update(string str)
        {
            this.State = str;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}\n",Name,State);
        }
    }
}
