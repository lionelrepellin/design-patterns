using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);
            
            var group = new CommandGroup<AddMoney>();
            group.Add(new AddMoney(bankAccount, 10));
            group.Add(new AddMoney(bankAccount, 10));
            //group.Add(new AddMoney(bankAccount, 10));
            group.Make(1);

            Console.Read();
        }

        //private static float Move(float dist, float angle, bool save)
        //{            
        //    if (save)
        //    {
        //        var mc = new MoveCommand(this, effDist, angle);
        //        this._cGroup.Add(mc);
        //    }
        //    return ...;
        //}
    }

    public class BankAccount
    {
        public decimal Amount { get; private set; }

        public BankAccount(decimal initialAmount)
        {
            Amount = initialAmount;
        }

        public void SetNewAvount(decimal amount)
        {
            Console.WriteLine("oldValue: {0} => newValue: {1}", Amount, amount);
            Amount = amount;
        }
    }

    public interface ICommand
    {
        void Do();

        void Undo();

        /// ----------------------------------------------------------
        /// <summary>
        /// Return true if the current action is undoable.
        /// </summary>
        /// ----------------------------------------------------------
        bool IsUndoable { get; }
    }

    /*
    public abstract class Command : ICommand
    {
        public abstract void Do();

        public abstract void Undo();

        /// ----------------------------------------------------------
        /// <summary>
        /// Undoable by default.
        /// </summary>
        /// ----------------------------------------------------------
        public virtual bool IsUndoable
        {
            get { return true; }
        }
    }
    */

    public class AddMoney : ICommand
    {
        private decimal _newValue;
        private decimal _oldValue;
        private BankAccount _bankAccount;

        public bool IsUndoable
        {
            get
            {
                return true;
                //throw new NotImplementedException();
            }
        }

        public AddMoney(BankAccount bankAccount, decimal value)
        {
            _newValue = value;
            _oldValue = bankAccount.Amount;
            _bankAccount = bankAccount;
        }

        public void Do()
        {
            var value = _bankAccount.Amount + _newValue;
            _bankAccount.SetNewAvount(value);
        }

        public void Undo()
        {
            _bankAccount.SetNewAvount(_oldValue);
        }
    }



    public class RemoveMoney : ICommand
    {
        private decimal _newValue;
        private decimal _oldValue;
        private BankAccount _bankAccount;

        public bool IsUndoable
        {
            get
            {
                return true;
                //throw new NotImplementedException();
            }
        }

        public RemoveMoney(BankAccount bankAccount, decimal value)
        {
            _newValue = value;
            _oldValue = bankAccount.Amount;
            _bankAccount = bankAccount;
        }

        public void Do()
        {
            var value = _bankAccount.Amount - _newValue;
            _bankAccount.SetNewAvount(value);
        }

        public void Undo()
        {
            _bankAccount.SetNewAvount(_oldValue);
        }
    }



    //public class JumpCommand : Command
    //{
    //    private IRobot _robot = null;
    //    private PointF _currentLocation = PointF.Empty;
    //    private PointF _oldLocation = PointF.Empty;

    //    public JumpCommand(IRobot robot, PointF oldLocation, PointF currentLocation)
    //    {
    //        if (robot == null) throw new ArgumentException("Robot cannot be null");
    //        this._robot = robot;
    //        this._oldLocation = oldLocation;
    //        this._currentLocation = currentLocation;
    //    }

    //    public override void Do()
    //    {
    //        this._robot.Jump(this._currentLocation);
    //    }

    //    public override void Undo()
    //    {
    //        this._robot.Jump(this._oldLocation);
    //    }
    //}


    //public class MoveCommand : Command
    //{
    //    private IRobot _robot = null;
    //    private float _dist = 0f;
    //    private float _angle = 0f;

    //    public MoveCommand(IRobot robot, float dist, float angle)
    //    {
    //        if (robot == null) throw new ArgumentException("Robot cannot be null");
    //        this._robot = robot;
    //        this._dist = dist;
    //        this._angle = angle;
    //    }

    //    public override void Do()
    //    {
    //        this._robot.Move(this._dist, this._angle);
    //    }

    //    public override void Undo()
    //    {
    //        this._robot.Move(-this._dist, this._angle);
    //    }

    //    /// ---------------------------------------------------------------
    //    /// <summary>
    //    /// This action is undoable only if the robot move more than 100.
    //    /// </summary>
    //    /// ---------------------------------------------------------------
    //    public override bool IsUndoable
    //    {
    //        get { return this._dist > 100; }
    //    }
    //}

    public class CommandGroup<T> where T : ICommand
    {
        private Stack<T> _commandsDo = new Stack<T>();
        private Stack<T> _commandsUndo = new Stack<T>();

        public void Add(T item)
        {
            this._commandsDo.Push(item);
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool CanDo
        {
            get { return _commandsUndo.Count > 0; }
        }

        public bool CanUndo
        {
            get { return _commandsDo.Count > 0 && this._commandsDo.Peek().IsUndoable; }
        }

        public void ClearAll()
        {
            _commandsDo.Clear();
            _commandsUndo.Clear();
        }

        public void Make(int count)
        {
            if (_commandsDo.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    var command = _commandsDo.Peek();
                    if (command.IsUndoable)
                    {
                        _commandsDo.Pop();
                        command.Do();
                        _commandsUndo.Push(command);
                    }
                }
            }
        }

        public void Undo(int count)
        {
            if (_commandsDo.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    var command = _commandsDo.Peek();
                    if (command.IsUndoable)
                    {
                        _commandsDo.Pop();
                        command.Undo();
                        _commandsUndo.Push(command);
                    }
                }
            }
            else throw new InvalidOperationException("Not enougth actions to undo");
        }

        public void Do(int count)
        {
            if (_commandsUndo.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    var command = _commandsUndo.Peek();
                    if (command.IsUndoable)
                    {
                        _commandsUndo.Pop();
                        command.Do();
                        _commandsDo.Push(command);
                    }
                }
            }
            else throw new InvalidOperationException("Not enougth actions to do");
        }
    }
}
