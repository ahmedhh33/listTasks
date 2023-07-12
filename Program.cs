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


        }

        //public static List removechar(List<string> list, char cs)
        //{
        //    if (list.Contains(cs))
        //    {

        //    }
        //}
    }
}