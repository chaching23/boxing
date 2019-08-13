using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> ice = new List<object>();
            ice.Add(7);
            ice.Add(28);
            ice.Add(-1);
            ice.Add(true);
            ice.Add("chair");

            for(int i = 0; i < ice.Count; i++){

            System.Console.WriteLine(ice[i]);

            }

          
            
        }







    }
}
