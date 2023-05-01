using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{

    /// <summary>
    /// Калькулятор
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="basis">основание</param>
        public Calculator(int basis)
        {
            Basis = basis;
        }

        /// <summary>
        /// Основание счисления
        /// </summary>
        public int Basis { get; protected set; }

        /// <summary>
        /// Сложение чисел
        /// </summary>
        /// <param name="a">Аргумент A</param>
        /// <param name="b">Аргумент B</param>
        /// <returns>Сумма</returns>
        public string Add(string a, string b)
        {
            int ia = Convert.ToInt32(a, Basis);
            int ib = Convert.ToInt32(b, Basis);
            return Convert.ToString(ia + ib, Basis);
        }

        /// <summary>
        /// Деление чисел
        /// </summary>
        /// <param name="a">Аргумент A</param>
        /// <param name="b">Аргумент B</param>
        /// <returns>Частное</returns>
        public string Div(string a, string b)
        {
            int ia = Convert.ToInt32(a, Basis);
            int ib = Convert.ToInt32(b, Basis);
            return Convert.ToString(ia / ib, Basis);
        }
    }

}
