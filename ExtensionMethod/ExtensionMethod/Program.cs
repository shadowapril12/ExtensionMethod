using System;
using System.Collections.Generic;
using System.Collections;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод дней относително текущей даты
            foreach (DateTime el in DateTime.Now.TakeDays(3))
            {
                Console.WriteLine(el);
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Статический класс для создания метода расширения класса DateTime
    /// </summary>
    static class DateExtension
    {
        /// <summary>
        /// TakeDays метд расширения класса DateTime, при помещение в цикл foreach возвращает итератор
        /// </summary>
        /// <param name="date">Текущая дата</param>
        /// <param name="count">Количество последующих дней</param>
        /// <returns></returns>
        public static IEnumerable<DateTime> TakeDays(this DateTime date, int count)
        {
            //В цикле к текущей дате прибавляется количество дней равное i
            for (int i = 1; i <= count; i++)
            {
                yield return date.AddDays(i);
            }
        }
    }
}
