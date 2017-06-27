using System;
using AntSimulator2017Abstract.Character;
namespace AntSimulator2017Abstract.State
{
    public interface IState
    {
        void updateCharacterState(Character.Character context, IState replacementState);

    }
}
