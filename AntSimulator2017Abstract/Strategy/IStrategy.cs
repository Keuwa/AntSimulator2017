using System;
namespace AntSimulator2017Abstract.Strategy
{
    public interface IStrategy
    {

        void UpdateCharacterStrategy(Character.Character context, IStrategy strategyReplacement);
        void Execute();
    }
}
