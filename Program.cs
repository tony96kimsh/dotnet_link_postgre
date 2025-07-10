// Program.cs
using System;
using Npgsql;

class Program
{
    static void Main ()
    {
        // PostgreSQL 접속 문자열
        string connString = 
            "Host=localhost;" +
            "Port=5342;" +  // 기본 포트 번호 5432 사용 시, 생략 가능
            "Username=postgres;" +
            "Password=post1234;" +
            "Database=postgres";
        try
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            Console.WriteLine("PostgreSQL 연결 성공");
        }
        catch (Exception ex)
        {
            Console.WriteLine("PostgreSQL 연결 실패: " + ex.Message);
        }        
    }
}