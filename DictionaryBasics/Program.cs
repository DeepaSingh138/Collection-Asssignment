namespace DictionaryBasics;
public class Program
{  
    public static void show_dictionary(Dictionary<string, int> dict)
    {
        foreach (KeyValuePair<string, int> pair in dict)
        {
            Console.WriteLine("{0} {1}", pair.Key, pair.Value);

        }

    }
      public static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int> { };
        dict.Add("Dobidobi:", 100);
        dict.Add("Meday:", 89);
        dict.Add("Bhutkun:", 90);
        dict.Add("Champion:",92);
        dict.Add("Deepa:", 34);
        Console.WriteLine("Student Diary contains:");
        show_dictionary(dict);
           dict["Champion:"] = 202;
        Console.WriteLine("Updated Student Diary");
        show_dictionary(dict);
        Console.WriteLine("Removed student from Student Diary");
        dict.Remove("Deepa:");
        show_dictionary(dict);
        Console.WriteLine("The specific student marks is:" + dict["Meday:"]);

    }
   
}


