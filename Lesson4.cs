using System;

namespace Lesson4 {
    internal class Program {

        public static void Run(string[] args) {
            Sanoq_sestem k = new Sanoq_sestem(15);
            Console.WriteLine(k.Ikkilik());
        }
    }
    class Sanoq_sestem
    {
        public int raqam;
        public Sanoq_sestem(int son)
        {
            this.raqam = son;
        }
        public string Ikkilik()
        {
            string a = "", b = "";
            while (this.raqam > 0)
            {
                a = a + this.raqam % 2;
                this.raqam = this.raqam / 2;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b = b + a[i];
            }
            return b;
        }
        public string K_to_N_system(int K, int a, int N)
        {
            // Avvalo: K sanoq tizimidagi a sonini 10-likka o'tkazamiz
            int decimalNumber = 0;
            int power = 1;

            while (a > 0)
            {
                int digit = a % 10;
                decimalNumber += digit * power;
                power *= K;
                a /= 10;
            }

            // Endi 10-lik sonni N sanoq tizimiga o'tkazamiz
            string numberN = "";
            string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (decimalNumber == 0)
                return "0";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % N;
                numberN = digits[remainder] + numberN;
                decimalNumber /= N;
            }

            return numberN;
        }

    }
}
