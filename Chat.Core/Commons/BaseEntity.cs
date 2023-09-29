namespace Chat.Core.Commons
{
    public abstract class BaseEntity : Entity, IDateEntity
    {
        public int ID { get; set; }
       
    }
}