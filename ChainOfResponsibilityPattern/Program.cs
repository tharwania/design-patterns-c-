using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderRequest = new OrderRequest()
            {
                Amount = 2500
            };

            var hanlderChain = new OrderValidationHandler()
            {
                NextHandler = new OrderOfferHandler()
                {
                    NextHandler = new OrderProcessorHandler()
                }
            };

            hanlderChain.Handle(orderRequest);
        }
    }


    interface IOrderHandler
    {
        IOrderHandler NextHandler { get; set; }
        void Handle(IRequest request);
    }

    public interface IRequest
    {
        decimal Amount { get; set; }
    }
    public class OrderRequest : IRequest
    {
        public decimal Amount { get; set; }
    }
    class OrderValidationHandler : IOrderHandler
    {
        public IOrderHandler NextHandler { get; set; }
        public void Handle(IRequest request)
        {
            if (request != null && request.Amount > 0)
            {
                this.NextHandler.Handle(request);
            }
            else
            {
                throw new Exception("Invalid Amount");
            }
        }
    }

    class OrderOfferHandler : IOrderHandler
    {
        public IOrderHandler NextHandler { get; set; }
        public void Handle(IRequest request)
        {
            if (request.Amount > 500)
            {
                request.Amount = 500 - 50;
            }
            this.NextHandler.Handle(request);
        }
    }

    class OrderProcessorHandler : IOrderHandler
    {
        public IOrderHandler NextHandler { get; set; }
        public void Handle(IRequest request)
        {
            Console.WriteLine($"Order For Amount: {request.Amount} Procesed Successfully");
        }
    }

}
