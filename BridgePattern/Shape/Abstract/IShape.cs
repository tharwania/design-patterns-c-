namespace BridgePattern
{
    interface IShape
    {
        IColor Color { get; set; }
        void Draw();
    }
}
