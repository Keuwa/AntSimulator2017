using System;

namespace AntSimulator2017Abstract.Environnement.Map
{
    public abstract class AbstractLink
    {
        public AbstractArea area1 { get; set; }
        public AbstractArea area2 { get; set; }
        public Boolean isOpen { get; set; }

    }
}
