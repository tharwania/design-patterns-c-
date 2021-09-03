namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape greenTriangle = new Triangle
            {
                Color = new GreenColor()
            };
            greenTriangle.Draw();

            IShape redRect = new Rectange
            {
                Color = new RedColor()
            };
            redRect.Draw();
        }
    }
}
