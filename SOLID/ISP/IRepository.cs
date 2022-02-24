namespace ISP
{
    public interface IRepositoryWriteOnly<T>
    {
        void Save(T obj);
        void Delete(T obj);
        void Update(T obj);
    }

    public interface IRepositoryReadOnly<T>
    {
        T Get();
        T GetAll();
    }

    public interface IRepository<T> : IRepositoryReadOnly<T>, IRepositoryWriteOnly<T>
    {
        
    }
}