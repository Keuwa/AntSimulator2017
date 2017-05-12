using System;
namespace AntSimulator2017Abstract.Strategy
{
    public interface IStrategy
    {
        void updateCharacterStrategy(Character.Character context, IStrategy strategyReplacement);
        void execute();
    }
}
