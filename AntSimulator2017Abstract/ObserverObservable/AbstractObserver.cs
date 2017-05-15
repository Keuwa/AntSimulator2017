using System;

namespace AntSimulator2017Abstract
{
    interface AbstractObserver
	{
        void update(AbstractObservable src,Object data);
	}
} 