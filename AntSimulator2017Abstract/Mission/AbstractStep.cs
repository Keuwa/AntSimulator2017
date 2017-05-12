using System;
namespace AntSimulator2017Abstract.Mission
{
    public abstract class AbstractStep
    {
        public abstract string name { get; }
        public Position position { get; }
    }
}
