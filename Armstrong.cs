    using System;

    class Program {
        static void Main() {

            for (int i = 1; i < 1000; i++) {
                if (isArmstrong(i)) {
                    Console.WriteLine(i);
                }
            }

            //Console.WriteLine(isArmstrong(153));

            static bool isArmstrong(int number) {
                int temp = number;
                int sum = 0;
                int digit = number.ToString().Length;

                while (temp != 0) {
                    int rem = temp % 10;
                    sum += (int)Math.Pow(rem, digit);
                    temp /= 10;
                }

                return sum == number;
            }
        }
    }
