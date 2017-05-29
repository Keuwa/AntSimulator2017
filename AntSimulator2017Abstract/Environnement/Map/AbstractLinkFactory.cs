using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract.Environnement.Map
{
    public abstract class AbstractLinkFactory
    {
        public abstract AbstractLink createLink(AbstractArea area1,AbstractArea area2);
    }
}
