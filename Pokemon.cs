using System;

// Breaking change for git test
namespace Pokemon
{
    public class Pokemon
    {
        public Pokemon()
        {
            Nickname = Name;
        }

        public Pokemon(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
        }

        /// <summary>
        /// Gets and sets the name of the Pokemon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets the nickname of the Pokemon
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets and sets the weight of the Pokemon
        /// </summary>
        public double Weight { get; set; }


        /// <summary>
        /// Gets and sets the type of the Pokemon
        /// </summary>
        public string Type { get; set; }

    }
}
