using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

///////////////////////////START OF TASK2
public class Task2
{
    //Take user input:
    public void Main()
    {
        Console.Write("Insert salary: \n");
        int salary = Convert.ToInt32(Console.ReadLine());
        int tax = 0;

        //Check if the salary needs to be taxed with income tax:
        if (salary > 1000)
        {
            tax = ((salary - 1000) * 10 / 100);
        }

        //Check if the salary needs to be taxed with social contributions:
        if (salary > 1000 && salary <= 4000)
        {
            tax = tax + ((salary - 1000) * 15 / 100);
        }
        Console.Write("Taxes needed to be paid: " + tax + ".\n");
        Console.Write("Salary after taxes is " + (salary - tax) + ".");
    }

}