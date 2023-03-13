using System.Text.RegularExpressions;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class StringCalculator
    {


        public int Calculate(string arg)
        {
            List<string> res = new List<string>();
            int sum;
            if (string.IsNullOrEmpty(arg))
            {
                return 0;
            }
            if(arg.Length>3 &&arg.Substring(0,2)=="\\\\")
            {
                res = arg.Substring(2).Split(arg[2]).ToList();
            }
            
            if (int.TryParse(arg, out int result))
            {
                res.Add(arg);
            }
            if (Regex.IsMatch(arg, "([0-9]+\n)+[0-9]+"))
            {
                res = arg.Split('\n').ToList();
            }
            if (Regex.IsMatch(arg, "([0-9]+,)+[0-9]+"))
            {
                res = arg.Split(',').ToList();
            }
            sum = 0;
            foreach (var n in res)
            {
                if (int.TryParse(n, out int numb))
                {
                    if(numb < 0)
                    {
                        throw new Exception();
                    }
                    else if (numb >= 1000)
                    {
                        continue;
                    }
                    sum += numb;
                }
               
            }
            return sum;

        }


        public static void Main()
        {
            String s = "-1";
            StringCalculator stringCalculator = new StringCalculator();
            Console.WriteLine("String s" + s + "calculated" + stringCalculator.Calculate(s));
        }
    }
}