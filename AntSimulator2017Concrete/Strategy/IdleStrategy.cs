using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Strategy
{
    public class IdleStrategy : BaseStrategy
    {

        public IdleStrategy(AntSimulator2017Abstract.Character.Character charac) : base(charac)
        {
        }

        public override void Execute()
        {
            //throw new NotImplementedException();
        }

        public override void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            //throw new NotImplementedException();
        }
    }
}
