namespace ChainOfResponsability
{
    public abstract class Popup
    {
        protected Popup Successor;

        public void SetSuccessor(Popup successor)
        {
            Successor = successor;
        }
        
        public abstract void ProcessRequest();
    }
}