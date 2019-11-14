using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class analaizerClass
    {
        private static int erposition = 0;

        public static int Erposition { get { return erposition; } }

        public static string expression = "";

        public static bool ShowMessage = true;

        public static bool CheckCurrency()
        {
            int bracket1 = 0;

            int bracket2 = 0;

            int error = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    if (bracket1 > bracket2)
                    {
                        erposition = i;

                        erposition++;

                        return false;
                    }

                    bracket1++;

                    error = i;
                }

                if (expression[i] == ')')
                {
                    if(error + 1 == i)
                    {
                        erposition = i;

                        erposition++;

                        return false;
                    }

                    bracket2++;

                    error = i;
                }
            }

            if (bracket1 != bracket2)
            {
                erposition = error;

                erposition++;

                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
