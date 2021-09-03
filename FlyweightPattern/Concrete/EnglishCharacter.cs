namespace FlyweightPattern
{
    class EnglishCharacter : ICharacter
    {
        public EnglishCharacter(char value)
        {
            this.Char = value;
        }
        public char Char { get; set; }
    }
}
