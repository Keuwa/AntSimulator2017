using System.Collections.Generic;

namespace AntSimulator2017Abstract.Environement
{
	public abstract class AbstractEnvironement:AbstractObservable
	{
        public AbstractArea [][] map {get;set;}
        public List <Base> bases {get;set;}

        public abstract void simulate();

        /// <summary>
        /// Gets the stats. Try to make it better
        /// </summary>
        /// <returns>The stats.</returns>
        public abstract string getStats();
	}
}
