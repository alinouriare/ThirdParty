using System;
using System.Collections.Generic;
using System.Text;

namespace Ssseion2.XUnitTest.Model
{
    public class FizFuzz
    {
        public string excute(int input)
        {
            //switch (input)
            //{
            //    case 1:
            //        return "1";
            //    case 2:
            //        return "1,2";
            //    default:
            //        return "1,2,fizz";
            //}
            List<object> result = new List<object>();

            for (int i = 1; i <= input; i++)
            {
                if (i % 5 == 0 &&i%3==0 )
                { result.Add("fizzfuzz"); }


              else  if (i%5==0)
                { result.Add("fuzz"); }
                    
               
              else  if (i%3 ==0)
                { result.Add("fizz"); }
                  
               
                else
                {
                    result.Add(i);
                }
                
            }
            return string.Join(",", result.ToArray());
           
        }
    }
}
