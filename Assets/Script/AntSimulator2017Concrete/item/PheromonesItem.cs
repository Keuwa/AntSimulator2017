using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Item;

namespace AntSimulator2017Concrete.item
{
    public class PheromonesItem : AbstractItem,IComparable<PheromonesItem>
    {
        public static String FOOD = "FOOD";
        public static String NEUTRAL = "NEUTRAL";
        public static String DANGER = "DANGER";
        public static int DURATION = 15;

        public String Type { get; set; }

        public int CompareTo(PheromonesItem y)
        {
            if (this == y) return 0;
			if (this == null) return -1;
			if (y == null) return 1;

			return String.Compare(this.Type, y.Type);        }
    }
}
