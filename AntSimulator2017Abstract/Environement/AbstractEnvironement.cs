using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract
{
	public abstract class AbstractEnvironement:AbstractObservable
	{
        AbstractArea [][] map {get;set;}
        List <Base> bases {get;set;}
	}
}
