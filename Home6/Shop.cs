using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Shop
    {
        private double _area;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public static Shop operator +(Shop shop, double value)
        {
            shop.Area += value;
            return shop;
        }

        public static Shop operator -(Shop shop, double value)
        {
            shop.Area -= value;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            if (ReferenceEquals(shop1, shop2))
            {
                return true;
            }

            if (ReferenceEquals(shop1, null) || ReferenceEquals(shop2, null))
            {
                return false;
            }

            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return !(shop1 == shop2);
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            if (ReferenceEquals(shop1, null))
            {
                return !ReferenceEquals(shop2, null);
            }

            return shop1.Area < shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            if (ReferenceEquals(shop2, null))
            {
                return !ReferenceEquals(shop1, null);
            }

            return shop1.Area > shop2.Area;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Shop;
            if (other == null)
            {
                return false;
            }

            return this.Area == other.Area;
        }
    }
}
