using Newtonsoft.Json.Linq;

//////////////////////////////////////////START OF TASK 1:


//Read the input.txt file
string text = System.IO.File.ReadAllText("input.txt");

//Parse the file as an array
JArray jsonArray = JArray.Parse(text);

//Loop for each object and pass it to MovieStar class
foreach (JObject jsonObject in jsonArray)
{
    MovieStar.jsonHandler(jsonObject);
}


//Start of MovieStar class
public class MovieStar
{
    //Function to handle what is needed to be printed
    public static void jsonHandler(JObject a)
    {
        JObject o1 = JObject.Parse(a.ToString());

        //Concatenate the name and the surname
        Console.WriteLine(o1["Name"] + " " + o1["Surname"]);

        //Print sex and nationality
        Console.WriteLine(o1["Sex"]);
        Console.WriteLine(o1["Nationality"]);

        //Get today's date and date from the file
        var today = DateTime.Today;
        var parsedDate = DateTime.Parse(o1["dateOfBirth"].ToString());

        // Calculate the age
        var age = today.Year - parsedDate.Year;
        Console.WriteLine(age + " years old");
        Console.WriteLine(" ");

    }
}
