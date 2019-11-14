using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcClass;

namespace AnalaizerClass
{
    public class analaizerClass
    {
        private static int erposition = 0;

        public static int Erposition { get { return erposition; } }

        public static string expression = "";

        public static bool ShowMessage = true;


        public static void Error01(char ch)
        {
            CalcClas.lastError = "Error 01 at " + ch;
        }


        public static bool CheckCurrency()
        {
            int bracket1 = 0;

            int bracket2 = 0;

            int error = -1;

            int positionBracket1 = -1;

            int positionBracket2 = -1;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    if (bracket1 > bracket2)  ////    
                    {
                        positionBracket1 = i;

                        ////erposition = i;
                        ////erposition++;
                        ////Error01('(');
                        ////return false;
                    }

                    bracket1++;

                    error = i;
                }

                if (expression[i] == ')')
                {
                    if(error + 1 == i)
                    {
                        positionBracket2 = i;

                        ////erposition = i;

                        ////erposition++;

                        ////Error01(')');

                        ////return false;
                    }

                    bracket2++;

                    error = i;
                }
            }

            if (bracket1 != bracket2)
            {
                if (positionBracket1 != -1)
                {
                    erposition = positionBracket1;

                    erposition++;

                    Error01('(');

                    return false;
                }


                if (positionBracket2 != -1)
                {
                    erposition = positionBracket2;


                    erposition++;

                    Error01(')');

                    return false;
                }






                erposition = error;

                erposition++;

                if (bracket1 > bracket2) 
                {
                    Error01('(');
                }
                else
                {
                    Error01(')');
                }

                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
