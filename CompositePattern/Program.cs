using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // we can compose object inside object and extend the functionaly
            // thats main benefit of decorator and composite pattern
            // but composite has array of object like tree 
            // and decorator has simple path like one line

            var apiException = new APICustomException();
            var businessException = new BusinessCustomException();
            var nullPointerException = new NullPointerCustomException();
            nullPointerException.AddChild(businessException);
            apiException.AddChild(nullPointerException);

            Console.WriteLine(apiException.GetMessage());

        }
    }


    interface CustomException
    {
        IList<CustomException> ChildrenCustomExceptions { get; set; }
        string GetMessage();
        void AddChild(CustomException exception);
    }

    internal abstract class SuperCustomException : CustomException
    {
        public SuperCustomException()
        {
            ChildrenCustomExceptions = new List<CustomException>();
        }
        public abstract string Message { get; }
        public IList<CustomException> ChildrenCustomExceptions { get; set; }

        public void AddChild(CustomException exception)
        {
            ChildrenCustomExceptions.Add(exception);
        }

        public string GetMessage()
        {
            if (ChildrenCustomExceptions != null)
            {
                var result = Message + " " +  string.Join(" ", ChildrenCustomExceptions.Select(x => x.GetMessage()).ToArray());
                return result;
            }

            return string.Empty;
        }
    }

    class NullPointerCustomException : SuperCustomException, CustomException
    {
        public override string Message => "I am null pointer Exception";
    }
    class BusinessCustomException : SuperCustomException, CustomException
    {
        public override string Message => "I am business violation Exception";
    }

    class APICustomException : SuperCustomException, CustomException
    {
        public override string Message => "I am api Exception";
    }

}


