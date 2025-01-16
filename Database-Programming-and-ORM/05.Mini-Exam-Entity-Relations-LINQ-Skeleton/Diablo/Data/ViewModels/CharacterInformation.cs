using System;
using System.Collections.Generic;
using System.Text;

namespace Diablo.Data.ViewModels
{
    public class CharactersInformation
    {
        public string Name { get; set; }

        public int GamesCount { get; set; }

        public ICollection<string> Games { get; set; }
    }
}
