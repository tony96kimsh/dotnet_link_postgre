// Program.cs
using EfDemoApp.Controllers;

class Program
{
    static void Main()
    {
        var DbController = new DbController();
        DbController.TestConnection();
    }
}