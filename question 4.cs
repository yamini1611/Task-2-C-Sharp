using System;

namespace Task_2
{
    internal class question_4
    {
        public void list(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter No of employees");
            int count =Convert.ToInt32(Console.ReadLine());
            question_4 listdetails = new question_4();
            Console.WriteLine(".Net Trainees");
            for(int i= 0; i < count; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age: ");
                string age = Console.ReadLine();

                Console.Write("Enter address: ");
                string address = Console.ReadLine();

                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();

                listdetails.list(name, age, address, phoneNumber);
            }
            

            Console.ReadLine(); 
        }
    }
}
