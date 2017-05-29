using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Abstract.Environnement
{
    public class AbstractEnvironnement:AbstractObservable
    {
        public List<Character.Character> Characters { get; set; }
        public List<AbstractHeadQuarter> HeadQuarters { get; set; }
        public AbstractMap Map { get; set; }



        public override void notify(object datas)
        {
            foreach (Character.Character character in Characters){
                character.update(this,datas);
            }
			foreach (AbstractHeadQuarter headQuarter in HeadQuarters)
			{
				headQuarter.update(this, datas);
			}
		}
    }
}
