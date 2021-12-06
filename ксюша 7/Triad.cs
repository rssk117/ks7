using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ксюша_7
{
    class Triad
    {
        public Triad(int numbers)
        {
            Number1 = numbers;
            Number2 = numbers;
            Number3 = numbers;
        }
        public Triad()
        {
            Number1 = 0;
            Number2 = 0;
            Number3 = 0;
        }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }

        public void SetParams(int setnumber1, int setnumber2, int setnumber3)
        {
            Number1 = setnumber1;
            Number2 = setnumber2;
            Number3 = setnumber3;
        }
        public static Triad operator ++(Triad triad)
        {
            triad.Number1++;
            triad.Number2++;
            triad.Number3++;
            return triad;
        }
        public static bool operator ==(Triad triad_1, Triad triad_2)
        {
            if (triad_1.Number1 != triad_2.Number1)
                return false;
            if (triad_1.Number2 != triad_2.Number2)
                return false;
            if (triad_1.Number2 != triad_2.Number3)
                return false;
            return true;
        }
        public static bool operator !=(Triad triad_1, Triad triad_2)
        {
            if (triad_1.Number1 == triad_2.Number1)
                return false;
            if (triad_1.Number2 == triad_2.Number3)
                return false;
            if (triad_1.Number2 == triad_2.Number3)
                return false;
            return true;
        }

        public static bool operator true(Triad triad)
        {
            if (triad.Number1 == triad.Number3 && triad.Number1 == triad.Number2)
                return true;
            return false;
        }
        public static bool operator false(Triad triad)
        {
            if (triad.Number1 != triad.Number3 || triad.Number1 != triad.Number2)
                return true;
            return false;
        }
    }
}
