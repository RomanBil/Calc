using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public class CalcClas
    {

        private static int CheckError09(long res)
        {
            if (res == 0) 
            {
                lastError = "Error 09";
                return -1;
            }

            return 1;
        }



        private static int CheckError06(long res)
        {
            if (-2147483648 < res || res > 2147483647)
            {
                lastError = "Error 06";
                return -1;
            }

            return 1;
        }

        /// <summary> 
        /// Функція складання числа а і b 
        /// </summary> 
        /// <param name="a">доданок</param> 
        /// <param name="b">доданок</param> 
        /// <returns>сума</returns> 
        public static int Add(long a, long b)
        {
            if (CheckError06(a) == -1)
            {
                return -1;
            }

            if (CheckError06(b) == -1)
            {
                return -1;
            }

            long res = (a + b);

            if (CheckError06(res) == -1)
            {
                return -1;
            }

            return (int)res;
        }

        /// <summary> 
        /// функція віднімання чисел а і b 
        /// </summary> 
        /// <param name="a">зменшуване</param> 
        /// <param name="b">від’ємне</param> 
        /// <returns>різниця</returns> 
        public static int Sub(long a, long b)
        {
            if (CheckError06(a) == -1)
            {
                return -1;
            }

            if (CheckError06(b) == -1)
            {
                return -1;
            }

            long res = (a - b);

            if (CheckError06(res) == -1)
            {
                return -1;
            }

            return (int)res;
        }


        /// <summary> 
        /// функція множення чисел а і b 
        /// </summary> 
        /// <param name="a">множник</param> 
        /// <param name="b">множник</param> 
        /// <returns>добуток</returns> 
        public static int Mult(long a, long b)
        {
            if (CheckError06(a) == -1)
            {
                return -1;
            }

            if (CheckError06(b) == -1)
            {
                return -1;
            }

            long res = (a * b);

            if (CheckError06(res) == -1)
            {
                return -1;
            }

            return (int)res;
        }

        /// <summary> 
        /// функція знаходження частки 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>частка</returns> 
        public static int Div(long a, long b)
        {
            if (CheckError09(b) == -1)
            {
                return -1;
            }



            if (CheckError06(a) == -1)
            {
                return -1;
            }

            if (CheckError06(b) == -1)
            {
                return -1;
            }

            long res = (a / b);

            if (CheckError06(res) == -1)
            {
                return -1;
            }

            return (int)res;
        }

        /// <summary> 
        /// функція ділення по модулю 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>остача</returns> 
        public static long Mod(long a, long b)
        {
            if (CheckError09(b) == -1)
            {
                return -1;
            }

            if (CheckError06(a) == -1)
            {
                return -1;
            }

            if (CheckError06(b) == -1)
            {
                return -1;
            }

            long res = (a % b);

            if (CheckError06(res) == -1)
            {
                return -1;
            }

            return (int)res;
        }


        /// <summary> 
        /// унарний плюс  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int ABS(long a)
        {
            if (CheckError06(a) == -1)
            {
                return -1;
            }
            return (int)a*-1;
        }

        /// <summary> 
        /// унарний мінус  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int IABS(long a)
        {
            if (CheckError06(a) == -1)
            {
                return -1;
            }
            return (int)a * -1;
        }


        ////Використовується також глобальна змінна: 
        /// <summary> 
        /// Останнє повідомлення про помилку. 
        /// Поле і властивість для нього 
        /// </summary> 
        private static string _lastError = "";

        ///public static string lastError

        public static string lastError
        {
            get { return _lastError; }

            set { _lastError = value; }
        }

       

    }
}
