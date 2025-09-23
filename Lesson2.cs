using System;


namespace Lesson2
{
    class Program
    {
        public static void Run(string[] args)
        {
            // Object yaratish
            Matematika obj = new Matematika(1, -3, 2);

            // Oddiy metodlar chaqiruvlari
            Console.WriteLine("a ning kvadrati: " + obj.Kv());
            Console.WriteLine("Kv tenglama yechimlari soni: " + obj.Lv());
            Console.WriteLine("Kub: " + obj.Cub());

            // Static metod chaqiruvlari
            Console.WriteLine("Kub: " + Matematika.Cub(3));

            // Masofa Xisoblash
            Kordinata k1 = new Kordinata(1, 2);
            Kordinata k2 = new Kordinata(4, 6);
            Console.WriteLine("Masofa: " + k1.Masofa(k2)); // Natija: 5
        }
    }
    class Matematika{
        public int a;
        public int b;
        public int c;

        public Matematika(int a, int b, int c){
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Kv() {
            return a * a;
        }
        
        public int Lv() {
            int d = b * b - 4 * a * c;
            if (d < 0) {
                return 0;
            } else if (d == 0) {
                return 1;
            } else {
                return 2;
            }
        }

        public int Cub() {
            return a * a * a;
        }

        public static int Cub(int a) {
            return a * a * a;
        }

    }

    class Kordinata {
        public int x;
        public int y;

        public Kordinata(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public double Masofa(Kordinata k) {
            return Math.Sqrt((k.x - this.x) * (k.x - this.x) + (k.y - this.y) * (k.y - this.y));
        }
    }

}
