namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseObject firstDbObject = new("hey You");
            firstDbObject.Print();
            var secondDbObject = firstDbObject.Clone();
            secondDbObject.Print();
        }
    }
}
