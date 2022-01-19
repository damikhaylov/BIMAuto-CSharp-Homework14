using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
                абстрактное свойство - название животного.
            В классе Animal нужно определить следующие методы:
                конструктор, устанавливающий значение по умолчанию для названия;
                абстрактный метод Say(), который выводит звук, который издает животное;
                неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
            Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
                свойство – название животного;
                метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
            Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
            */

            Console.WriteLine("Отображение информации о животных с использованием классов\n");
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
        abstract class Animal
        {
            protected string species;
            public Animal()
            {
                species = "Животное";
            }
            public abstract string Species { get; }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.Write("{0} говорит \"", Species);
                Say();
                Console.WriteLine("!\"");
            }
        }
        class Cat : Animal
        {
            public Cat()
            {
                species = "Кошка";
            }
            public override string Species
            {
                get
                {
                    return species;
                }
            }
            public override void Say()
            {
                Console.Write("Мяу");
            }
        }
        class Dog : Animal
        {
            public Dog()
            {
                species = "Собака";
            }
            public override string Species
            {
                get
                {
                    return species;
                }
            }
            public override void Say()
            {
                Console.Write("Гав");
            }
        }
    }
}
