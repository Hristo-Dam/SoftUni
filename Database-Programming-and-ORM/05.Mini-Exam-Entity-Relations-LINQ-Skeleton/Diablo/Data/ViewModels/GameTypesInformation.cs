using System;
using System.Collections.Generic;
using System.Text;

namespace Diablo.Data.ViewModels
{
    public class GameTypesInformation
    {
        public string Name { get; set; }

        public ICollection<string> GamesNames { get; set; }
    }
}
