using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


    class LittleJohn
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat(" {0}", Console.ReadLine());
            }
            string patern="(>>>----->>)|(>----->)|(>>----->)";
            Regex reg = new Regex(patern);
            MatchCollection mach= reg.Matches(sb.ToString());
            int largeArrow = 0;
            int smallArrow = 0;
            int mediumArrow = 0;
            foreach (var item in mach)
            {
                if (item.ToString() == ">>>----->>")
                {
                    largeArrow++;
                }
                else if (item.ToString() == ">----->")
                {
                    smallArrow++;
                }
                else if (item.ToString() == ">>----->")
                {
                    mediumArrow++;
                }
                
            }
            string number = Convert.ToString( string.Format("{0}{1}{2}", smallArrow, mediumArrow, largeArrow));
            int num=int.Parse(number);
            string binary = Convert.ToString(num, 2);
            string reverse =new string( binary.Reverse().ToArray());
            string result = binary + reverse;
            int totalResult = Convert.ToInt32(result, 2);
            Console.WriteLine(totalResult);
        }
    }

