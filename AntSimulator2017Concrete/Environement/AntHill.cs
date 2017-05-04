using System;
using AntSimulator2017Abstract.Environement;
using AntSimulator2017Abstract;
using AntSimulator2017Concrete.Environement.Character;


namespace AntSimulator2017Concrete.Environement
{
    public class AntHill : Base
    {
        public AntHill()
        {
            /// Test constructor , need to be removed
            this.characterList = new System.Collections.Generic.List<AntSimulator2017Abstract.AbstractObserver>();
            for (int i = 0; i < 10; i++)
            {
                characterList.Add(new Ant("Ant " + i));
            }
            ///
        }

        public override void notify()
        {
            foreach (AbstractObserver abstractObserver in observerList)
            {
                int i = 0;
                if (i % 2 == 1)
                {
                    abstractObserver.update("base notified");
                }
                i++;
            }
        }

        public override string getStats()
        {
            string result = "";
            foreach (Ant ant in characterList)
            {
                result += ant.ToString();
            }
            return result;
        }
    }
}
