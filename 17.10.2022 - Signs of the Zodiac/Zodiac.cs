using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._10._2022___Signs_of_the_Zodiac
{
    internal class Zodiac : IEnumerable
    {

        string[] zodiac = { "Овен",  "Телец", "Близнецы", "Рак", "Лев",
            "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };

        public IEnumerator GetEnumerator() => zodiac.GetEnumerator();

    }

}
