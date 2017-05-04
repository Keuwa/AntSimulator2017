using System.Collections.Generic;

namespace AntSimulator2017Abstract.Environement
{
    public abstract class Base : AbstractObservable
    {
        public List<AbstractObserver> characterList{get;set;}
        public Position pos {get;set;}

        /// <summary>
        /// Gets the stats. Make it better
        /// </summary>
        /// <returns>The stats.</returns>
        public abstract string getStats();
    }
}
