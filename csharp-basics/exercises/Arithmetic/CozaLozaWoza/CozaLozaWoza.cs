namespace CozaLozaWoza
{
    public class CozaLozaWoza
    {
        public static string PlayCozaLozaWoza(int min, int max)
        {
            var res = "";
            for (var i = min; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    res += "CozaLozaWoza ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    res += "CozaLoza ";
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    res += "CozaWoza ";
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    res += "LozaWoza ";
                }
                else if (i % 3 == 0)
                {
                    res += "Coza ";
                }
                else if (i % 5 == 0)
                {
                    res += "Loza ";
                }
                else if (i % 7 == 0)
                {
                    res += "Woza ";
                }
                else
                {
                    res += i + " ";
                }
            }

            return res;
        }
    }
}
