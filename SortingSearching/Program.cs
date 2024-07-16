using System;

namespace SortingSearching;


public class Program { 
    public int num;
     public static void show_list(List<int> num)
    {
        foreach (int i in num)
        {
            Console.WriteLine(i);
        
        }
              public static void Main(string[] args)
    {
        List<int> num = new List<int>();
        num.Add(26);
        num.Add(46);
        num.Add(21);
        num.Add(6);
        num.Add(28);
        num.Add(29);
        num.Add(30);
        num.Add(19);
        num.Add(23);
        num.Add(2); 
        Console.WriteLine("Random integer are:");
       show_list(num);
        Console.WriteLine("Sorted integer list:");
        num.Sort();
        show_list(num);
        Console.WriteLine("Desecneding order of integer list:");
        num.Reverse();
        show_list(num);
        if (num.Contains(23))
        {
            Console.WriteLine("Yes your lucky number 23 is in list");
        }

    }
}
