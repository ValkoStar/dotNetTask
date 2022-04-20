
using Newtonsoft.Json.Linq;

string text = System.IO.File.ReadAllText("input.txt");

JArray jsonArray = JArray.Parse(text);

foreach (JObject jsonObject in jsonArray)
{
    MovieName.test(jsonObject);
}


public class MovieName
{
    public static void test(JObject a)
    {
        JObject o1 = JObject.Parse(a.ToString());
        Console.WriteLine(o1["Name"] + " " + o1["Surname"]);
        Console.WriteLine(o1["Sex"]);
        Console.WriteLine(o1["Nationality"]);
        var today = DateTime.Today;
        var parsedDate = DateTime.Parse(o1["dateOfBirth"].ToString());
        // Calculate the age.
        var age = today.Year - parsedDate.Year;
        Console.WriteLine(age + " years old");
        Console.WriteLine(" ");

    }
}
