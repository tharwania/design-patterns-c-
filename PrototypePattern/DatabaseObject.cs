using System;

namespace PrototypePattern
{
    class DatabaseObject : IPrototypableDabataseObject
    {
        private string privateField;
        public string publicField;

        DatabaseObject()
        {

        }
        public DatabaseObject(string publicField)
        {
            this.publicField = publicField;
            privateField = publicField.ToUpper();
        }
        public IPrototypableDabataseObject Clone()
        {
            return new DatabaseObject()
            {
                privateField = privateField,
                publicField = publicField
            };
        }

        public void Print()
        {
            Console.WriteLine($"Private Field is {privateField} and Public Field is {publicField}");
        }
    }
}
