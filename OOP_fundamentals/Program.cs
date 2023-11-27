using OOP_fundamentals;
using System.Text.Json.Nodes;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer c1 = new Customer("Peter", Person.Genders.Male, new DateTime(1992, 02, 10), "peter12@gmail.com");
        Console.WriteLine(c1.ToString());
        RegistrationEmail regEmail = new RegistrationEmail
        {
            From = "alparvantsa@gmail.com",
            To = "antalzsolt@enetix.ro",
            Subject = "Registration",
            CustomerName = "Antal Zsolt",
            UserName = "antalzsolt",
            Password = "asd321",
            WebsiteName = "Enetix",
            WebsiteUrl = "https://enetix.ro/hu/"
        };
        EmailSender.Send(regEmail);

        OrderNotificationEmail orderEmail = new OrderNotificationEmail
        {
            From = "alparvantsa@gmail.com",
            To = "antalzsolt@enetix.ro",
            Subject = "Registration",
            CustomerName = "Antal Zsolt",
            WebsiteName = "Enetix",
            OrderNumber = 123,
            OrderUrl = "https://enetix.ro/hu/awb/123"
        };
        EmailSender.Send(orderEmail);
        Console.ReadLine();

    }
}