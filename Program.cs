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
            "Username=postgres;" +
            "Password=post1234;" +
            "Database=postgres";
        
        using var conn = new NpgsqlConnection(connString);
        conn.Open(); // 연결을 실제로 여는 함수        
    }
}