﻿using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Concrete.Character;

namespace AntSimulator2017Concrete.HQ
{
    public class AntHillFactory : AbstractHeadQuarterFactory
    {
        
        public override AbstractHeadQuarter createHQ(Position pos)
        {
            AntHill anthill = new AntHill();
            anthill.queen = (Queen)new QueenFactory().createCharacter("Reine 1",pos);
            anthill.attach(new GathererFactory().createCharacter("Jean michel Gatherer",new Position(pos.x+1,pos.y)));
            anthill.attach(new WarriorFactory().createCharacter("Pierre henry Warrior", new Position(pos.x - 1, pos.y)));
            anthill.attach(new ExplorerFactory().createCharacter("Michel Antoine Explorer", new Position(pos.x, pos.y + 1)));
            return anthill;
        }
    }
}
