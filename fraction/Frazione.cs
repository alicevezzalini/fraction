using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    internal class Frazione
    {
        public int N { get; set; }
        public  int  D { get; set; }

        public Frazione(int n, int d) 
        { 
            this.N = n;
            this.D = d;
        }

        public override string ToString()
        {
            return $"{N}/{D}";
        }

        public static Frazione Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Frazione(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static bool operator ==(Frazione f1, Frazione f2) {
            if (object.ReferenceEquals(f1, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return false;
            else
                return f1.N == f2.N && f2.D == f1.D;        
        }

        public static bool operator!=(Frazione f1, Frazione f2)
        {
            return !(f1 == f2);
        }

        public int CompareTo()
        {
            return N / D;
        }

        public static bool operator>(Frazione f1 , Frazione f2)
        {
            return f1.CompareTo() > f2.CompareTo();
        }

        public static bool operator<(Frazione f1, Frazione f2)
        {
            return f1.CompareTo() < f2.CompareTo();
        }

        public static bool operator>=(Frazione f1, Frazione f2)
        {
            return f1.CompareTo() >= f2.CompareTo();
        }

        public static bool operator<=(Frazione f1,Frazione f2)
        {
            return f1.CompareTo() <= f2.CompareTo();
        }
    }
}
