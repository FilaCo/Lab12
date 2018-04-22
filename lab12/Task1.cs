﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using Ships;

namespace lab12
{
    class Task1
    {
        /// <summary>
        /// Процедура вывода на экран основной информации по задаче
        /// </summary>
        private static void Intro()
        {
            Console.WriteLine(@"Постановка задачи 1:

1. Создать коллекцию Stack, в которую добавить объекты иерархии классов Ships.
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
        private static Stack GenerateStack(int length)
        {
            Stack nStack = new Stack(length * 2);
            for (int i = 0; i < length; i++)
                switch(Program.rnd.Next(0,3))
                {
                    case 0:
                        nStack.Push(new SailingShip());
                        break;
                    case 1:
                        nStack.Push(new SteamShip());
                        break;
                    case 2:
                        nStack.Push(new Corvette());
                        break;
                }
            return nStack;
        }
        private static void PrintStack(Stack curStack)
        {
            Console.WriteLine("Количество элементов в коллекции: {0}", curStack.Count);
            foreach (Ship x in curStack)
            {
                Console.WriteLine("+--------------------------------------+");
                x.Show();
            }
            Console.WriteLine("+--------------------------------------+");
        }
        private static void InputName(Ship elem)
        {
            Console.WriteLine("Введите имя нового корабля (оставьте пустым для генерации с помощью ДСЧ):");
            string inpStr = Console.ReadLine();
            if (inpStr != "")
                elem.Name = inpStr;
        }
        private static void InputMaxSpeed(Ship elem)
        {
            Console.WriteLine("Введите максимальную скорость (оставьте пустым для генерации с помощью ДСЧ):");
            bool check = false;
            string inpStr = "";
            while (!check)
            {
                try
                {
                    inpStr = Console.ReadLine();
                    if (inpStr == "")
                        return;
                    elem.MaxSpeed = Convert.ToInt32(inpStr);
                    check = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    check = false;
                }
            }
        }
        private static void InputDateReleased(Ship elem)
        {
            Console.WriteLine("Введите дату выпуска корабля (оставьте пустым для генерации с помощью ДСЧ):");
            bool check = false;
            string inpStr = "";
            while (!check)
            {
                try
                {
                    inpStr = Console.ReadLine();
                    if (inpStr == "")
                        return;
                    elem.DateReleased = inpStr;
                    check = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    check = false;
                }
            }
        }
        private static void InputElemFromKeyboard(Ship elem)
        {
            InputName(elem);
            InputMaxSpeed(elem);
            InputDateReleased(elem);
            if (elem is SteamShip)
            {
                if (elem.GetType() == typeof(Corvette))
                {

                }
            }
            if (elem is SailingShip)
            {

            }
        }
        private static void PushElem(Stack curStack)
        {
            Ship nElem = null;
            switch (Program.Menu("Выберите тип добавляемого элемента", "Пароход", "Парусник", "Корвет"))
            {
                case 0:
                    nElem = new SteamShip();
                    break;
                case 1:
                    nElem = new SailingShip();
                    break;
                case 2:
                    nElem = new Corvette();
                    break;
            }
            switch(Program.Menu("Выберите метод генерации элемента", "Ввод с клавиатуры", "С помощью ДСЧ"))
            {
                case 0:
                    break;
            }

        }
        private static void PrintAllTheFastest(Stack curStack)
        {

        }
        private static void CountShipsOlder1970(Stack curStack)
        {

        }
        private static void PrintAllEmptyCorvettes(Stack curStack)
        {

        }
        private static void EnumItems(Stack curStack)
        {

        }
        private static void GetClone(Stack curStack)
        {

        }
        private static Stack SortStack(Stack curStack)
        {
            return null;
        }
        private static void FindElem(Stack curStack)
        {

        }
        public static void Solve()
        {
            Intro();
            Console.WriteLine("Введите количество элементов, которые будут сгенерированы в коллекции:");
            int begLength = Program.ReadNonNegativeNum("Количество элементов");
            Stack taskCollection = GenerateStack(begLength);
            while (true)
            {
                switch (Program.Menu("Выберите действие", "Показать коллекцию", "Добавить элемент в коллекцию", 
                    "Удалить элемент из коллекции", "Вывести самые быстроходные суда в коллекции", 
                    "Вывести количество судов, выпущенных ранее 1970 года","Вывести все корветты с пустым боезапасом", 
                    "Перебрать элементы коллекции", "Клонировать коллекцию","Отсортировать коллекцию", 
                    "Найти элемент коллекции по параметру", "Вернуться к выбору задания","Выход"))
                {
                    case 0:
                        Console.WriteLine("Сейчас коллекция выглядит так:");
                        PrintStack(taskCollection);
                        break;
                    case 1:
                        PushElem(taskCollection);
                        break;
                    case 2:
                        taskCollection.Pop();
                        break;
                    case 3:
                        PrintAllTheFastest(taskCollection);
                        break;
                    case 4:
                        CountShipsOlder1970(taskCollection);
                        break;
                    case 5:
                        PrintAllEmptyCorvettes(taskCollection);
                        break;
                    case 6:
                        EnumItems(taskCollection);
                        break;
                    case 7:
                        GetClone(taskCollection);
                        break;
                    case 8:
                        taskCollection = SortStack(taskCollection);
                        break;
                    case 9:
                        FindElem(taskCollection);
                        break;
                    case 10:
                        return;
                    case 11:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Для продолжения работы нажмите Enter...");
                Console.ReadLine();
            }
        }
    }
}
