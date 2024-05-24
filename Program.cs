using System;
using System.Linq;

namespace Ultra_Bigger_Calcuator
{
    internal class Program
    {
        static void Main(string[] args)
        {

                return data;


            //   1110
            //   1109
            //  -
            //  --------  
            //   0001

                Console.WriteLine(ex);
                return null;
            }


        }
        static void Summer(string bgInt1, string bgInt2)
        {



            bool isError = false;

            string bigger = "";
            string lower = "";

            if (bgInt2.Length < bgInt1.Length)
            {
                string zeros = new string('0', bgInt1.Length - bgInt2.Length);
                bgInt2 = zeros + bgInt2;
                lower = bgInt2;
                bigger = bgInt1;
                Console.WriteLine(bigger);
            }
            if (bgInt1.Length < bgInt2.Length)
            {
                string zeros = new string('0', bgInt2.Length - bgInt1.Length);
                bgInt1 = zeros + bgInt1;
                lower = bgInt1;
                bigger = bgInt2;
                Console.WriteLine(bigger);
            }
            {
                lower = bgInt1;
                bigger = bgInt2;
            }


            string str = "";


            int sum = 0;

            bool arttir = false;
            for (int i = bigger.Length - 1; i >= 0; i--)
            {

                if (int.TryParse(bigger[i].ToString(), out int one) && int.TryParse(lower[i].ToString(), out int second))
                {

                    if (arttir)
                    {
                        one++;
                    }

                    if ((one + second) >= 10)
                    {
                        sum = (one + second) - 10;
                        arttir = true;
                    }
                    else
                    {
                        sum = (one) + second;

                        arttir = false;
                    }
                    str += sum;

                    {
                        str += 1;
                    }
                }
                else
                {
                    isError = true;
                }
            }

            if (!isError)
            {
                string yeniString = "";
                for (int i = str.Length; i > 0; i--)
                {
                    yeniString += str[i - 1].ToString();
                }


                Console.WriteLine(str);
                string trimmedString = yeniString.TrimStart('0');

                Console.WriteLine(trimmedString);
            }
        }
        {
            bool isError = false;

            if (bgInt2.Length < bgInt1.Length)
            {
                string zeros = new string('0', bgInt1.Length - bgInt2.Length);
                bgInt2 = zeros + bgInt2;
            }



            string str = "";


            int sum = 0;

            bool azalt = false;
            for (int i = bgInt1.Length - 1; i >= 0; i--)
            {

                if (int.TryParse(bgInt1[i].ToString(), out int one) && int.TryParse(bgInt2[i].ToString(), out int second))
                {

                    if (azalt)
                    {
                        one--;
                    }

                    if (one < second)
                    {
                        //     Console.WriteLine((one + 10) - second);
                        sum = (one + 10) - second;


                        azalt = true;
                    }
                    else
                    {
                        sum = (one) - second;

                        azalt = false;
                    }

                    str += sum;

                }
                else
                {
                    isError = true;
                }
            }

            if (!isError)
            {
                string yeniString = "";
                for (int i = str.Length; i > 0; i--)
                {
                    yeniString += str[i - 1].ToString();
                }


                if (_negative)
                {
                    Console.WriteLine("-" + yeniString.TrimStart('0'));
                }
                else
                {
                    Console.WriteLine(yeniString.TrimStart('0'));

            }
        }
       
    }

    public class Data
    {
        public string data1 { get; set; }


        public string data2 { get; set; }

        public bool negative { get; set; }

        public Data(string _dataone1, string _dataone2, bool _negative)
        {
            data1 = _dataone1;
            data2 = _dataone2;
            negative = _negative;
        }

}
}
