using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class CommandGroup<T> where T : ICommand
    {
        private Stack<T> _commandsDo = new Stack<T>();
        private Stack<T> _commandsUndo = new Stack<T>();

        public void Add(T item)
        {
            Console.WriteLine("Add");
            _commandsDo.Push(item);
            item.Do();
            Console.WriteLine();
        }

        public void ClearAll()
        {
            _commandsDo.Clear();
            _commandsUndo.Clear();
        }

        public void UnDo()
        {
            if (_commandsDo.Any())
            {
                Console.WriteLine("UnDo");
                var lastCommand = _commandsDo.Pop();
                lastCommand.Undo();
                _commandsUndo.Push(lastCommand);
                Console.WriteLine();
            }
        }

        public void ReDo()
        {
            if (_commandsUndo.Any())
            {
                Console.WriteLine("ReDo");
                var lastUndoCommand = _commandsUndo.Pop();
                lastUndoCommand.Do();
                _commandsDo.Push(lastUndoCommand);
                Console.WriteLine();
            }
        }
    }
}
