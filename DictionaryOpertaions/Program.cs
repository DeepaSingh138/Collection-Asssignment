using DictionaryOpertaions;
using System.ComponentModel;
using System.Runtime;

namespace DictionaryOperations;
public class Program
{
    public  static void show_user(Dictionary<Person,string> usr)
    {
        foreach (KeyValuePair<Person,string> human in usr)
        {

            Console.WriteLine($"{human.Key.Firstname}{human.Key.Lastname}: {human.Value}");
               
            //Console.WriteLine( human.Key + human.Value);

        }

    }
    public static void Main(string[] args)
    {

        Dictionary<Person,string> profile = new Dictionary<Person,string>();
        var user1 = new Person("Deepa", "Singh");
        var user2 = new Person("Shivan","Singh");        var user3 = new Person("Priya", "Arora");
        profile[user1] = "Deepa@mail.com";
        profile[user2] = "singh@23mail.com";
        profile[user3] = "hitach@mail.com";
        //profile.Add(user1, "Deepa@mail.com");
        //profile.Add(user2, "singh@23mail.com");
        //profile.Add(user3, "hitach@mail.com");
        //Console.Write("The profile of users are :");
        show_user(profile);

        profile[user2] = "Shivani@Hotmail.com";
        Console.WriteLine("\n Updated email:");
        show_user(profile);
        profile.Remove(user1);
        Console.WriteLine("\n Removing any one user:");
        show_user(profile);
    }
}