namespace DataProvider.Base;
public interface IBaseEntity
{
}
public abstract class BaseEntity<T> : IBaseEntity
{
    public T Id { get; set; }

    // last changes datetime
    public DateTime ModifiedDate { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}

// this is default for id 
//you see default id type is long
public abstract class BaseEntity : BaseEntity<int>
{
}