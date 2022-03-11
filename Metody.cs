using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meotdy09_14GitHub
{
    class Metody
    {
        public static double Diskriminant(double a, double b, double c, out double x1, out double x2, out double d)
        {
            d = (b * b) - (4 * a * c);
            x1 = 0;
            x2 = 0;
            if (d < 0)
            {
                d = 0;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
            }
            return d;
        }
        public static bool ObsahujeCislici(string idk, out int cifSoucet, out int lichCifSoucet, out int sudCifSoucet)
        {
            bool obsahujeCislici = false;
            cifSoucet = 0;
            lichCifSoucet = 0;
            sudCifSoucet = 0;
            for (int i = 0; i < idk.Length; ++i)
            {
                if (Char.IsNumber(idk[i]))
                {
                    obsahujeCislici = true;
                    cifSoucet += int.Parse(idk[i].ToString());

                    if (int.Parse(idk[i].ToString()) % 2 != 0)
                    {
                        lichCifSoucet += int.Parse(idk[i].ToString());
                    }
                    else if (int.Parse(idk[i].ToString()) % 2 == 0)
                    {
                        sudCifSoucet += int.Parse(idk[i].ToString());
                    }
                }
            }

            return obsahujeCislici;
        }
        //int PocetSlov(string a, out string sUpraveno)
        //{
        //    int pocSlov = 0;
        //    string[] sOddeleno;
        //    char[] separator = { ' ' };
        //    sOddeleno = a.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        //    pocSlov = sOddeleno.Length;

        //    int i = 0;
        //    while(i < a.Length - 1)
        //    {
        //        if (a[i] >= '0' && a[i] <= '9')
        //        {
        //            a = a.Remove(i, 1);
        //        }
        //        else ++i;
        //    }
        //    sUpraveno = a;
        //    return pocSlov;
        //}
        public static int PocetSlov(ref string a)
        {
            int pocSlov = 0;
            string[] sOddeleno;
            char[] separator = { ' ' };
            sOddeleno = a.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            pocSlov = sOddeleno.Length;

            int i = 0;
            while (i < a.Length - 1)
            {
                if (a[i] >= '0' && a[i] <= '9')
                {
                    a = a.Remove(i, 1);
                }
                else ++i;
            }
            return pocSlov;
        }

        public static bool ObsahujeSlovo(string text, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            bool obsahujeslovo = false;
            nejdelsiSlovo = "";
            nejkratsiSlovo = text;
            int pocetPismenMax = 0;
            int pocetPismenMin = text.Length;
            char[] separators = { ' ' };
            string[] poleSlov = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in poleSlov)
            {
                if (s.Length >= 1)
                {
                    obsahujeslovo = true;
                }
                if (s.Length > pocetPismenMax)
                {
                    pocetPismenMax = s.Length;
                    nejdelsiSlovo = s;
                }
                if (s.Length < pocetPismenMin)
                {
                    pocetPismenMin = s.Length;
                    nejkratsiSlovo = s;
                }
            }
            return obsahujeslovo;
        }

        public static bool JeAlfanum(string s, out int pocetMalychPismen, out int pocetVelkychPismen, out int pocetJinychZnaku)
        {
            bool jealfanum = false;
            pocetMalychPismen = 0;
            pocetVelkychPismen = 0;
            pocetJinychZnaku = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                if (Char.IsLetterOrDigit(s[i]))
                {
                    jealfanum = true;
                    if (Char.IsUpper(s[i])) ++pocetVelkychPismen;
                    else if (Char.IsLower(s[i])) ++pocetMalychPismen;
                }
                else
                {
                    ++pocetJinychZnaku;
                    jealfanum = false;
                }
            }
            return jealfanum;
        }
        public static bool Identicke(string s1, string s2, out int pocOdlis, out int indexPrvOdlis)
        {
            pocOdlis = 0;
            indexPrvOdlis = -1;
            bool jeIdenticke = true;
            string sKybl;
            if(s1.Length != s2.Length)
            {
                jeIdenticke = false;
                if (s1.Length > s2.Length)
                {
                    sKybl = s1;
                    s1 = s2;
                    s2 = sKybl;
                }
                pocOdlis += (s2.Length - s1.Length);
            }
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i]!=s2[i])
                {
                    jeIdenticke = false;
                    pocOdlis++;
                    if (indexPrvOdlis == -1) indexPrvOdlis = i;
                }
            }
            if(!jeIdenticke && indexPrvOdlis == -1)
            {
                indexPrvOdlis = s1.Length;
            }
            return jeIdenticke;
        }
    }
}
