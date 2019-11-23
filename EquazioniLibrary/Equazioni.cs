using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if (a != 0)
            {
                return true;
            }
            else
                return false;

        }
        public static bool IsInconsisted(double a)
        {
            if (a == 0)
            {
                return true;
            } else
                return false;
        }
        public static bool IsDegree2(double a, double b)
        {
            if (a != 0)
            {
                return true;
            }
            else
                return false;


        }
        public static double Delta(double a , double b, double c)
        {
            return (b*b)-4*a*c;

        }
        public static string EquationDegree1(double a ,double b)
        {
            if (a == 0 || b == 0)
            {
                return "Indeterminato";
            }
            if (a != 0 || b == 0)
            {
                return "Impossibile";
            }
            double risultato = -b / a;
            
            return risultato.ToString(); 
        }


    }
}
