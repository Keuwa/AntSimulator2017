﻿using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Strategy
{
    public class BringStrategy : IStrategy
    {
        public BringStrategy()
        {
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            throw new NotImplementedException();
        }
    }
}
