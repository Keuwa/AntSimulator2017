using System;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission.step
{
    public class Shifting : AbstractStep
    {
        public Shifting()
        {
        }

        public override string name => "Deplacement vers l'objectif";
    }
}
