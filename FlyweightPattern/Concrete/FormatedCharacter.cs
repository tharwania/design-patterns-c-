namespace FlyweightPattern
{
    class FormatedCharacter : ICharacterProperties
    {
        public ICharacter Character { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
    }
}
