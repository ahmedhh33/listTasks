namespace Listtasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Write a program that takes a list of integers as input and removes duplicate numbers
             , keeping only the unique elements. 
             Implement a method that accepts the list and returns 
             a new list containing only the unique elements in the original order.
            */

            Console.WriteLine("Task 1");
            List<int> listWithDoublicate = new List<int>();
            listWithDoublicate.Add(1);
            listWithDoublicate.Add(2);
            listWithDoublicate.Add(3);    
            listWithDoublicate.Add(2);
            listWithDoublicate.Add(3);
            listWithDoublicate.Add(4);
            listWithDoublicate.Add(5);
            Console.WriteLine("With doublicates numbers");
            foreach (int i in listWithDoublicate)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Without doublicates numbers");
            List<int> listWithoutDoublicate = listWithDoublicate.Distinct().ToList();
            //listWithDoublicate.Distinct();//so we must creet anuther list and make distinct methode 

            foreach (int i in listWithoutDoublicate)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Task 2");

            /* 2. Implement a program that takes a list of strings as input 
             and performs the following operations:
            */

            List<String> stringlist = new List<String>();
            stringlist.Add("Ahmed");
            stringlist.Add("Salim");
            stringlist.Add("Nasser");
            stringlist.Add("Ali");
            stringlist.Add("Adli");

            Console.WriteLine("Remove all elements that contain a specific character specified by the user.");
            stringlist.RemoveAll(x => x.Contains("a"));

            foreach(String St in stringlist)
            {
                Console.WriteLine(St);
            }

            Console.WriteLine("Sort the remaining elements in ascending order");

            stringlist.Sort();
            foreach (String St in stringlist)
            {
                Console.WriteLine(St);
            }

            Console.WriteLine("Task 3");
            //Console.WriteLine("Return the modified list.");
            /* 3. Write a program that finds the maximum value in a list of integers.
             Implement a method that accepts the list as input and returns the maximum value.
            */
            List<int> intList = new List<int>()
            {
                1, 2, 3,23,35,65,32,54
            };

            Console.WriteLine($"The maximum number is : { intList.Max()}");

            Console.WriteLine("Task 4");
            /* 4. Write a program that takes a string as an input and is a sentence. 
             It should return a string with words in reverse order.")
            */

            
            List<string> hellowords = new List<string>() { " Hy ", " My ", " Name ", " is ", " Ahmed " };
            Console.WriteLine("befor reverse");
            foreach(String St in hellowords)
            {
                Console.Write(St);
            }
            Console.WriteLine();
            hellowords.Reverse();
            Console.WriteLine("after reverse");
            foreach (string St in hellowords)
            {
                Console.Write(St);
            }
            Console.WriteLine();
        }

        //public static List removechar(List<string> list, char cs)
        //{
        //    if (list.Contains(cs))
        //    {

        //    }
        //}
    }
}