using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private Stack<string> _stack;
        
        public bool IsEmpty()
        {
            if(this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stack<string> AddRange(Stack<string> fullStack)
        {
            this._stack = fullStack;
            return this._stack;
        }
    }
}
