
using System.Collections.Generic;
public class Service
{
    DB db;

    public Service()
    {
        db = new DB();
    }
    public void CreateTable()
    {
        db.GetConnection().DropTable<Animals>();
        db.GetConnection().CreateTable<Animals>();

        db.GetConnection().DropTable<Sick_leave>();
        db.GetConnection().CreateTable<Sick_leave>();

        db.GetConnection().DropTable<Owners>();
        db.GetConnection().CreateTable<Owners>();

        db.GetConnection().DropTable<Veterinarians>();
        db.GetConnection().CreateTable<Veterinarians>();

        db.GetConnection().DropTable<Visiting>();
        db.GetConnection().CreateTable<Visiting>();
    }
    public int GetNextOwnerId()
    {
        var conn = db.GetConnection();
        var maxId = conn.Table<Owners>().OrderByDescending(o => o.ID_Owners).FirstOrDefault()?.ID_Owners;
        return (maxId ?? 0) + 1;
    }
    public int Add<T>(T entity) where T : class
    {
        var conn = db.GetConnection();
        conn.Insert(entity);
        long lastId = conn.ExecuteScalar<long>("select last_insert_rowid()");
        return (int)lastId;
    }
    public IEnumerable<T> GetAll<T>() where T : class, new()
    {
        return db.GetConnection().Table<T>();
    }
    public int Update<T>(T entity) where T : class
    {
        return db.GetConnection().Update(entity);
    }
}

