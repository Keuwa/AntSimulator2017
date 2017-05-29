using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Environnement.Map;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class LinkFactory:AbstractLinkFactory
    {
        public override AbstractLink createLink(AbstractArea area1,AbstractArea area2){
            Link link = new Link();
            link.area1 = area1;
            link.area2 = area2;

            area1.links.Add(link);
            area2.links.Add(link);
            return link;
        }
    }
}
