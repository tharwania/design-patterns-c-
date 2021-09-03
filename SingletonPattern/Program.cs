using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // can't do, bacause private constructor
            // var singletonDatabaseConnection = new();

            var singletonDatabaseConnection = SingletonDatabaseConnection.GetInstance();
            singletonDatabaseConnection.Initiate();

            Console.WriteLine(singletonDatabaseConnection.GetState());

            var SecondSingletonDatabaseConnection = SingletonDatabaseConnection.GetInstance();
            Console.WriteLine(SecondSingletonDatabaseConnection.GetState());

        }
    }

    class SingletonDatabaseConnection
    {
        private string state = "Just Got Created";
        private static SingletonDatabaseConnection instance;
        private static object mutex = new object();

        private SingletonDatabaseConnection() { }

        public static SingletonDatabaseConnection GetInstance()
        {
            lock (mutex)
            {
                if (instance == null)
                {
                    instance = new SingletonDatabaseConnection();
                }

                return instance;
            }
        }

        public string GetState()
        {
            return this.state;
        }

        public void Initiate()
        {
            this.state = "Initiated";
        }
    }
}
