using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.State;

namespace AntSimulator2017Concrete.State
{
    public class DangerState : IState
    {
        public DangerState()
        {
        }

        public void updateCharacterState(AntSimulator2017Abstract.Character.Character context, IState replacementState)
        {
            throw new NotImplementedException();
        }
    }
}
