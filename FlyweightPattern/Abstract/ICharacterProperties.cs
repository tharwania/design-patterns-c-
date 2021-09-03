namespace FlyweightPattern
{
    interface ICharacterProperties
    {
        ICharacter Character { get; set; }
        bool Bold { get; set; }
        bool Italic { get; set; }
    }
}
