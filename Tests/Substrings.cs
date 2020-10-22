using System;
using System.IO;
using System.Text;

namespace Tests

{
    public static class Substrings
    {
        public static void subs()
        {
            var input = "Skador, förgiftningar och vissa andra följder av yttre orsaker (S00-T98)";
            var reader = new StreamReader(@".\resources\input.txt", Encoding.GetEncoding("iso-8859-1"));
            var x = reader.ReadLine();
            var b = "T35-T55";
            var sinputC = input.Substring(input.IndexOf("(")+1,7);
            var sinputN1 = sinputC.Substring(1, 2);
            var sinputN2 = sinputC.Substring(5, 2);
            if (sinputC.Substring(0, 1).Equals(sinputC.Substring(4, 1)))
                if (b.Substring(0, 1).Equals(sinputC.Substring(0, 1)) && Int32.Parse(b.Substring(1, 2)) >= Int32.Parse(sinputN1) && Int32.Parse(b.Substring(1, 2)) <= Int32.Parse(sinputN2))
                    Console.WriteLine(string.Format("{0} {1} {2} {3}", b, sinputC, sinputN1, sinputN2));
                else return;
            else
            {
                if (b.Substring(0, 1).Equals(sinputC.Substring(0, 1)))
                    if (int.Parse(b.Substring(1, 2)) <= Int32.Parse(sinputC.Substring(1, 2)))
                        Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                else
                        {
                            if (b.Substring(0, 1).Equals(sinputC.Substring(4, 1)))
                            {
                                if (int.Parse(b.Substring(1, 2)) <= Int32.Parse(sinputC.Substring(5, 2)))
                                    Console.WriteLine("YES");
                                else Console.WriteLine("NO");
                            }
                        }
                Console.WriteLine("NO");
            }

          }
    }
}
