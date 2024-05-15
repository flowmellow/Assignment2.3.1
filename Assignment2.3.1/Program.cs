//Write a console application to create a text file and save your basic details like name, age, address ( use dummy data).
//Read the details from same file and print on console.

namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteMethod();
            ReadMethod();


        }
        public static void WriteMethod()
        {
            Console.WriteLine("Hello, please enter your name:  ");
            string myName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your address: ");
            string address = Console.ReadLine();
            Console.WriteLine();

            try
            {
                StreamWriter testTxt = new StreamWriter("C:\\MSSA\\WriteText.txt");
                testTxt.WriteLine("Your name is: " + myName);
                testTxt.WriteLine();
                testTxt.WriteLine("Your age is: " + age);
                testTxt.WriteLine();
                testTxt.WriteLine("Your address is: " + address);
                testTxt.WriteLine();
                testTxt.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("File is saved.");
                Console.WriteLine();
            }
        }

        public static void ReadMethod()
        {

            string read;

            try
            {
                StreamReader readTxt = new StreamReader("C:\\MSSA\\WriteText.txt");
                read = readTxt.ReadLine();

                while (read != null)
                {
                    Console.WriteLine(read);
                    read = readTxt.ReadLine();

                }
                readTxt.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("All done. Hit enter to close the console app.");
            }

        }

    }   
}
