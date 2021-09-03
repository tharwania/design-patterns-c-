using System.Collections.Generic;

namespace FlyweightPattern
{
    class CharFlyweightFactory
    {
        Dictionary<char, ICharacter> charactersCache;
        public CharFlyweightFactory()
        {
            charactersCache = new Dictionary<char, ICharacter>();
        }

        public ICharacter GetCharacter(char value)
        {
            if (!charactersCache.ContainsKey(value))
            {
                charactersCache.Add(value, new EnglishCharacter(value));
            }

            return charactersCache[value];
        }
    }
}
