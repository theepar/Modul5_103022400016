using System;

namespace Modul5_103022400016
{
    public class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T x, T y, T z)
        {

            dynamic a = x;
            dynamic b = y;
            dynamic c = z;
            dynamic temp = a;

            if (temp < b)
            {
                temp = b;
            }
            if (temp < c)
            {
                temp = c;
            }
            return temp;
        }
    }
    
}