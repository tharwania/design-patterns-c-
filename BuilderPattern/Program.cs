using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your QueryType");
            Console.WriteLine("1. SqlServer");
            Console.WriteLine("2. MySql");
            var output = Console.ReadLine();

            var queryBuilder = CreateBuilder(output);
            var query = queryBuilder.Select("Order")
                .Conditon("price", ">", "10")
                .Order("price", "ASC")
                .Build();

            Console.WriteLine(query);

            Console.ReadKey();
        }

        private static ISqlQueryBuilder CreateBuilder(string output)
        {
            switch (output)
            {
                case "1":
                    return new SqlServerQueryBuilder();
                case "2":
                    return new MySqlQueryBuilder();
                default:
                    return new MySqlQueryBuilder();
            }
        }
    }
}
