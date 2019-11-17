using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCalc
{
    public class CalcClass
    {
        public static bool isError = false;
        public static string _lastError = "";
        public static decimal Add(decimal a, decimal b)
        {
            if (IsError06("+", a, b))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return a + b;
        }
        public static decimal Sub(decimal a, decimal b)
        {
            if (IsError06("-", a, b))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return a - b;
        }
        public static decimal Mult(decimal a, decimal b)
        {
            if (IsError06("*", a, b))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return a * b;
        }
        public static decimal Div(decimal a, decimal b)
        {
            if (b == 0)
            {
                _lastError = "Error 09";
                isError = true;
                return 0;
            }
            if (IsError06("/", a, b))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return a / b;
        }
        public static decimal Mod(decimal a, decimal b)
        {
            if (b == 0)
            {
                _lastError = "Error 09";
                isError = true;
                return 0;
            }
            if (IsError06("%", a, b))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return a % b;
        }
        public static decimal ABS(decimal a)
        {
            if (IsError06("", a, null))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return Math.Abs(a);
        }
        public static decimal IABS(decimal a)
        {
            if (IsError06("", a, null))
            {
                _lastError = "Error 06";
                isError = true;
                return 0;
            }
            return -a;
        }
        private static bool IsError06(string s, decimal a, decimal? b)
        {
            if (b != null)
            {
                switch (s)
                {
                    case "+": return (a < -2147483648 || a > 2147483647 || b < -2147483648 || b > 2147483647 || (a + b) < -2147483648 || (a + b) > 2147483647);
                    case "-": return (a < -2147483648 || a > 2147483647 || b < -2147483648 || b > 2147483647 || (a - b) < -2147483648 || (a - b) > 2147483647);
                    case "*": return (a < -2147483648 || a > 2147483647 || b < -2147483648 || b > 2147483647 || (a * b) < -2147483648 || (a * b) > 2147483647);
                    case "/": return (a < -2147483648 || a > 2147483647 || b < -2147483648 || b > 2147483647 || (a / b) < -2147483648 || (a / b) > 2147483647);
                    default: return (a < -2147483648 || a > 2147483647 || b < -2147483648 || b > 2147483647 || (a % b) < -2147483648 || (a % b) > 2147483647);
                }
            }
            else
            {
                return (a < -2147483648 || a > 2147483647);
            }
        }
    }
}
