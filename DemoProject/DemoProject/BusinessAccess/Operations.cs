using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProject.BusinessAccess
{
    public class Operations
    {
        public int Add(int a,int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b,int c)
        {
            return (a * b * c);
        }
    }
}
