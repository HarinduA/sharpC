using System;

namespace HelloWorld1
{

    public static class Invoice
    {
        // Fields
        private static int[] numbers;
        private static String name;
        private static int  age;

        // Constructor
        static Invoice()
        {
           // numbers = new int[] { 1, 2, 3 ,4}; // Initialize the array
        }

        public static void DisplayInvoiceAmount(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        public static int[] GetNumbers() // Method to return the array
        {
            return numbers;
        }

    }
}    