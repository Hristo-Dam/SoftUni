using System;
using System.Collections.Generic;
using System.Text;

namespace Diablo.Data.ViewModels
{
    public class UserGamesInformation
    {
        public string GameName { get; set; }

        public string CharacterName { get; set; }

        public ICollection<string> ItemsNames { get; set; }
    }
}
