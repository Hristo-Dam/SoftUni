using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books {  get; set; }

        public Library(params Book[] Books)
        {
            this.Books = new List<Book>(Books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < this.Books.Count; i++)
            {
                yield return this.Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
