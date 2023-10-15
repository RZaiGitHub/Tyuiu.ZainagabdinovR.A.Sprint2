using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint2.Task6.V5.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #2                                                                *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #2.6                                                            *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Игральным картам условно присвоены следующие порядковые номера *");
            Console.WriteLine("* в зависимости от их достоинства: «валету» — 11, «даме» — 12,            *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14.                                             *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям             *");
            Console.WriteLine("* («шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14)*");
            Console.WriteLine("* определить достоинство соответствующей карты.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер карта: ");
            int Card = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((Card < 6) || (Card > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Название карты = " + ds.FindCardValue(Card);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
