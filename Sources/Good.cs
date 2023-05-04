using System;

namespace Napilnik.Sources
{
    public class Good
    {
        public string Name { get; private set; }
        
        public Good(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            
            Name = name;
        }
    }
}