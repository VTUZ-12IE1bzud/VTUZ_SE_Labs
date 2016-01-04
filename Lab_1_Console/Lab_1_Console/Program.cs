using System;

namespace Lab_1_Console {
    class Program {
        static void Main(string[] args) {
            ShowMessage(ResString.Message);

            ShowMessage(ResString.PressAnyKey);
            Console.ReadKey();
        }

        public static void ShowMessage(string msg) {
            if (msg != null) {
                Console.WriteLine(msg);
            }
        }
        
    }
}
