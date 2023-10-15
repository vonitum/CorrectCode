using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCode
{
    public class CorrectCodeLibrary
    {
        /// <summary>
        /// Метод принимает в качестве параметра строку. 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>Метод возвращает true, если входная строка соответствует следующим условиям:
        /// строка имеет правильную длину;
        /// десятый символ строки (контрольное значение) содержит правильную цифру.
        /// При нарушении данных условий, метод возвращает false.
        /// </returns>
        public static bool IsCorrectCode(string candidate)
        {
            if (candidate.Length != 10)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(candidate))
            {
                return false;
            }


            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(candidate[i]))
                {
                    return false;
                }

                sum += int.Parse(candidate[i].ToString());
            }
            int control = 9;
            if (sum % 10 == 0)
            {
                control = 0;
            }
            else if (sum % 3 == 0)
            {
                control = 1;
            }
            else
            {
                control = 9;
            }
            if (int.Parse(candidate[9].ToString()) != control)
            {
                return false;
            }

            return true;
        }

    }
}
