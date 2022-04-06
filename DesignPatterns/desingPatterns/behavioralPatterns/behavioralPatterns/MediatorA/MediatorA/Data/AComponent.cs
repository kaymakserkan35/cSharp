namespace MediatorA.Data
{
    public abstract class AComponent
    {
        protected IMediator mediator;

        public AComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        abstract public string toString();



    }
}