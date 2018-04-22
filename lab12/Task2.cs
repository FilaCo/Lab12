﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Task2
    {
        public static void Intro()
        {
            Console.WriteLine(@"Постановка задачи 2:

1. Создать обобщенную  коллекцию List<T>, в которую добавить объекты иерархии классов Ships.
2. Используя меню, реализовать в программе добавление и удаление объектов коллекции.
3. Разработать и реализовать три запроса:
    а. Вывод характеристик самого быстроходного судна (всех судов, если их несколько).
    б. Вывод количества судов, которые были выпущены ранее 1970 года.
    в. Вывод всех корветтов с пустым боезапасом.
4. Выполнить перебор элементов коллекции с помощью метода foreach. 
5. Выполнить клонирование коллекции.
6. Выполнить сортировку коллекции (если коллекция не отсортирована) и поиск заданного элемента в коллекции.");
            Console.WriteLine("\nДля продолжения работы нажмите Enter...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Solve()
        {
            Intro();

        }
    }
}
