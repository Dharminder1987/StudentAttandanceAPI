namespace StudentAttandance.Data
{
    public interface IDataRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
