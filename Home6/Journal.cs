using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Journal
    {
        private int _numEmploye;

        public int NumEmploye
        {
            get { return _numEmploye; }
            set { _numEmploye = value; }
        }

        public static Journal operator +(Journal journal, int value)
        {
            journal.NumEmploye += value;
            return journal;
        }

        public static Journal operator -(Journal journal, int value)
        {
            journal.NumEmploye -= value;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            if (ReferenceEquals(journal1, journal2))
            {
                return true;
            }

            if (ReferenceEquals(journal1, null) || ReferenceEquals(journal2, null))
            {
                return false;
            }

            return journal1.NumEmploye == journal2.NumEmploye;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            if (ReferenceEquals(journal1, null))
            {
                return !ReferenceEquals(journal2, null);
            }

            return journal1.NumEmploye < journal2.NumEmploye;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            if (ReferenceEquals(journal2, null))
            {
                return !ReferenceEquals(journal1, null);
            }

            return journal1.NumEmploye > journal2.NumEmploye;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Journal;
            if (other == null)
            {
                return false;
            }

            return this.NumEmploye == other.NumEmploye;
        }
    }
}
