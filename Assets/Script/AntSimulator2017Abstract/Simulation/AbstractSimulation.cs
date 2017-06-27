using System;
using AntSimulator2017Abstract.Environnement;

namespace AntSimulator2017Abstract.Simulation
{
    public abstract class AbstractSimulation
    {
        public static AbstractSimulation Instance { get; set; }
        public int NumberOfTurn { get; set; }
        public AbstractEnvironnement Environnement { get; set; }
        public Random Random { get; set; }
    }
}
