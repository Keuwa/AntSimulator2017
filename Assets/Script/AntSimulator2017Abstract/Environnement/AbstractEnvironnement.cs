using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Abstract.Environnement
{
    public abstract class AbstractEnvironnement:AbstractObservable
    {
		public abstract void Armagedon();
		public abstract void AcidRain ();
        //public List<Character.Character> Characters { get; set; }
        public List<AbstractHeadQuarter> HeadQuarters { get; set; }
        public AbstractMap Map { get; set; }

        public abstract String Draw();

        public override void notify(object datas)
        {
            foreach (Character.Character character in this.ObserverList){
                character.update(this,datas);
            }
			foreach (AbstractHeadQuarter headQuarter in HeadQuarters)
			{
				headQuarter.update(this, datas);
			}
		}
    }
}
