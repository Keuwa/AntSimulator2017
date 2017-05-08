using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission
{
    public class Explore : AbstractMission
    {
        public Explore()
        {
        }

        public override string title => "Exploration de contrées inconnu";

        protected override List<AbstractStep> steps { get => steps; set => steps = value; }
    }
}
