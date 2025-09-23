using System;

namespace Lesson1
{
    class Program {
        public static void Run(string[] args)
        {
            Mashina mashina1 = new Mashina();
            mashina1.model = "BMW";
            mashina1.speed = 100;
            mashina1.masofa = 200;
            mashina1.maxSpeed = 300;
            mashina1.maxMasofa = 400;

            Mashina mashina2 = new Mashina();
            mashina2.model = "Mers";
            mashina2.speed = 100;
            mashina2.masofa = 200;
            mashina2.maxSpeed = 300;
            mashina2.maxMasofa = 400;
            Person person1 = new Person();
            person1.yosh = 20;
            Console.WriteLine(person1.yosh);
        }

    }
    class Person {
        public int yosh=10;
    }


    class Mashina
    {
        public string model="Car";
        public int speed;
        public int masofa;
        public int maxSpeed;
        public int maxMasofa;
    }



    class BankBalance
    {
        private int balance;

        public int kirim(int summa)
        {
            if (summa>0){
                return 0;
            }
            balance += summa;
            return summa;
        }
        public int chiqim(int chiqim){
            if (chiqim>balance || chiqim<=0){
                return 0;
            }
            balance -= chiqim;
            return chiqim;
        }
    }
}

