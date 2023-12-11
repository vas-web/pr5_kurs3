using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Triad
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public void Result(out int oA, out int oB, out int oC)
        {
            oA = A;
            oB = B;
            oC = C;
        }
        public void SetParams(int a, int b, int c, bool abc)
        {
            if (abc)
            {
                A = a + 10;
                B = b + 10;
                C = c + 10;
            }
        }
        public void SetParams(int a, int b, int c)
        {
            A = a + 1;
            B = b + 1;
            C = c + 1;
        }
    }
}
