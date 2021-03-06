﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /*
            Посчитать сколько раз каждое слово встречается в заданном тексте.
            Результат записать в коллекцию Dictionary<TKey,TValue>.

                    Вот дом,
                    Который построил Джек.

                    А это пшеница,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    А это весёлая птица-синица,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    Вот кот,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    Вот пёс без хвоста,
                    Который за шиворот треплет кота,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    А это корова безрогая,
                    Лягнувшая старого пса без хвоста,
                    Который за шиворот треплет кота,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    А это старушка, седая и строгая,
                    Которая доит корову безрогую,
                    Лягнувшую старого пса без хвоста,
                    Который за шиворот треплет кота,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    А это ленивый и толстый пастух,
                    Который бранится с коровницей строгою,
                    Которая доит корову безрогую,
                    Лягнувшую старого пса без хвоста,
                    Который за шиворот треплет кота,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.

                    Вот два петуха,
                    Которые будят того пастуха,
                    Который бранится с коровницей строгою,
                    Которая доит корову безрогую,
                    Лягнувшую старого пса без хвоста,
                    Который за шиворот треплет кота,
                    Который пугает и ловит синицу,
                    Которая часто ворует пшеницу,
                    Которая в тёмном чулане хранится
                    В доме,
                    Который построил Джек.
         */


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
         

            string text = "Вот дом," +
                "Который построил Джек." +
                "А это пшеница," +
                "Которая в тёмном чулане хранится" +
                "В доме," +
                "Который построил Джек." +
                "А это весёлая птица-синица," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "Вот кот," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "Вот пёс без хвоста," +
                "Который за шиворот треплет кота," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "А это корова безрогая," +
                "Лягнувшая старого пса без хвоста," +
                "Который за шиворот треплет кота," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "А это старушка, седая и строгая," +
                "Которая доит корову безрогую," +
                "Лягнувшую старого пса без хвоста," +
                "Который за шиворот треплет кота," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "А это ленивый и толстый пастух," +
                "Который бранится с коровницей строгою," +
                "Которая доит корову безрогую," +
                "Лягнувшую старого пса без хвоста," +
                "Который за шиворот треплет кота," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек." +
                "Вот два петуха," +
                "Которые будят того пастуха," +
                "Который бранится с коровницей строгою," +
                "Которая доит корову безрогую," +
                "Лягнувшую старого пса без хвоста," +
                "Который за шиворот треплет кота," +
                "Который пугает и ловит синицу," +
                "Которая часто ворует пшеницу," +
                "Которая в тёмном чулане хранится," +
                "В доме," +
                "Который построил Джек.";

            char[] separators = new Char[] { ',', ' ', '.' };
            string[] substrings = text.Split(separators);
            foreach (var substring in substrings)
                Console.WriteLine(substring);



            Console.Read();
        }
    }
}
