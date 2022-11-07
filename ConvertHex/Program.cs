using System;

namespace ConvertHex {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ConvertToHex("hello world"));
        }

        public static string ConvertToHex(string input) {
            string output = "";

            foreach (char character in input) {
                output += new string(((int) character).ToString("x")) + " ";
            }

            return output.Trim();
        }
    }
}
