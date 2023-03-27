using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private List<object> _stack;
        private int _sizeStack = 0;

        public Stack()
        {
            _stack = new List<object>();
            if (_stack == null)
            {
                throw new InvalidOperationException("Stack memory allocation failed.");
            }
        }

        public void Push(object item)
        {
            if (item == null)
            {
                throw new InvalidOperationException("\nException1: Item cannot be null!\n");
            }
            _stack.Add(item);
            ++_sizeStack;
            return;
        }
        public object Pop()
        {
            if (_sizeStack == 0)
            {
                throw new InvalidOperationException("\nException 2: Can't do a pop from an empty stack.\n");
            }
            object o = _stack[_sizeStack-1];
            _stack.RemoveAt(_sizeStack - 1);
            --_sizeStack;
            return o;
        }

        public void Clear()
        {
            _stack.Clear();
            return;
        }
    }
}
