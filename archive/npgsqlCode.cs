/*
// Program.cs
using System;
using Npgsql;

class Program
{
    static void Main ()
    {
        // PostgreSQL 접속 문자열
        // 기본포트 사용 시, Port 생략가능
        string connString = 
            @"Host=localhost;
            Port=5342;
            Username=postgres;
            Password=post1234;
            Database=postgres";
        
        try
        {
            // 1. postgre 연결
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            Console.WriteLine("PostgreSQL 연결 성공");

            // 2. 테이블 생성
            string createTableSql = "CREATE TABLE IF NOT EXISTS demo(id SERIAL PRIMARY KEY, name TEXT)";
            using var cmd = new NpgsqlCommand(createTableSql, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("테이블 생성 완료 혹은 이미 존재");

            // 3 테이블 출력
            string listTablesSql = @"
                select tablename
                from pg_catalog.pg_tables
                where schemaname = 'public'";

            using var listCmd = new NpgsqlCommand(listTablesSql, conn);
            using (var reader = listCmd.ExecuteReader())
            {
                Console.WriteLine("\n public 스키마 테이블 목록");
                while (reader.Read())
                {
                    Console.WriteLine("- " + reader.GetString(0));
                }
            }
            // 4-3 데이터 삽입
            string insertSql = @"insert into demo (name) values (@name)";
            using var cmdInsert = new NpgsqlCommand(insertSql, conn);
            cmdInsert.Parameters.AddWithValue("name", "성훈");
            cmdInsert.ExecuteNonQuery();
            Console.WriteLine("데이터 삽입 완료");
        }
        catch (Exception ex)
        {
            Console.WriteLine("PostgreSQL 연결 실패: " + ex.Message);
        }        
    }
}
*/