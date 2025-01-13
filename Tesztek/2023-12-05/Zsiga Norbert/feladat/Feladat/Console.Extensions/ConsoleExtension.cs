namespace ExtendedConsole

{
    public static class ConsoleExtension
    {
        public static double ReadDouble(string prompt, int minimum)
        {
            bool isDouble = false;
            double result = 0;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isDouble = double.TryParse(input, out result);

            } while (!isDouble || result < minimum);

            return result;
        }

    }
}
