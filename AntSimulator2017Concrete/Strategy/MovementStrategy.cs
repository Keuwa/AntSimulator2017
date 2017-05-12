using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Strategy;
namespace AntSimulator2017Concrete.Strategy
{
    public class MovementStrategy : IStrategy
    {
        public MovementStrategy()
        {
        }

        public void execute()
        {
            throw new NotImplementedException();
        }

        public void updateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            throw new NotImplementedException();
        }
    }
}
