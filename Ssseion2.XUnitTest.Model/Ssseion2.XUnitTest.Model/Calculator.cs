using System;
using System.Collections.Generic;
using System.Text;

namespace Ssseion2.XUnitTest.Model
{
    public class Calculator
    {
        public Calculator()
        {
            System.Threading.Thread.Sleep(3000);
        }
        public int Reuslt { get; set; }

        public void Add(int num01,int num02)
        {
             Reuslt= num01 + num02 ;

        }


        public int men(int num01, int num02)
        {
            throw new Exception();
            Reuslt= num01 - num02;

        }
    }
}
