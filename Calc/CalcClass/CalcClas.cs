using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public class CalcClas
    {
        /// <summary> 
        /// Функція складання числа а і b 
        /// </summary> 
        /// <param name="a">доданок</param> 
        /// <param name="b">доданок</param> 
        /// <returns>сума</returns> 
        public static int Add(long а, long b)
        {
            int res = (int)(а + b);
            if (-2147483648 < res || res > 2147483647)
            {
                lastError = "Error";
                return 0;
            }
            else return res;


        }

        /// <summary> 
        /// функція віднімання чисел а і b 
        /// </summary> 
        /// <param name="a">зменшуване</param> 
        /// <param name="b">від’ємне</param> 
        /// <returns>різниця</returns> 
        public static int Sub(long а, long b) { return (int)(а - b); }


        /// <summary> 
        /// функція множення чисел а і b 
        /// </summary> 
        /// <param name="a">множник</param> 
        /// <param name="b">множник</param> 
        /// <returns>добуток</returns> 
        public static int Mult(long а, long b) { return (int)(а * b); }

        /// <summary> 
        /// функція знаходження частки 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>частка</returns> 
        public static int Div(long а, long b) { return (int)(а / b); }

        /// <summary> 
        /// функція ділення по модулю 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>остача</returns> 
        public static long Mod(long а, long b)
        {
            ////if (a == b) return 0;
            ////if (a < b) return a;
            return (int)(а % b);
        }


        /// <summary> 
        /// унарний плюс  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int ABS(long а) { return 1; }

        /// <summary> 
        /// унарний мінус  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int IABS(long а) { return 1; }


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
