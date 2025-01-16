using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private List<string> _list;

        public string RandomString()
        {
            Random rnd = new Random();
            int elementToRemove = rnd.Next(0, _list.Count);
            string elementToReturn = _list[elementToRemove];
            _list.Remove(_list[elementToRemove]);
            return elementToReturn;
        }
    }
}
