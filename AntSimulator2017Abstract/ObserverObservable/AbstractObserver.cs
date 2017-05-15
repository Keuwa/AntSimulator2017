using System;

namespace AntSimulator2017Abstract
{
    public interface AbstractObserver
	{
        void update(AbstractObservable src,Object data);
	}
} 