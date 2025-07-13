using System;
using EfDemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EfDemoApp.Controllers
{
  public class DbController
  {
    public void TestConnection()
    {
      try
      {
        using var context = new DemoContext();
        context.Database.OpenConnection();
        Console.WriteLine("EF Core를 통한 Postgre SQL 연결 성공");
        context.Database.CloseConnection();
      }
      catch (Exception ex)
      {
        Console.WriteLine("PostgreSQL 연결 실패" + ex.Message);
      }
    }
  }
}