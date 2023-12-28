
using System.Collections.Generic;
using UnityEngine;

public class ServiceVisiting
{ 
     DB db;
    public ServiceVisiting()
    {
        db = new DB();
    }
    public Visiting GetEmployeeName(string value)
    {
        return db.GetConnection().Table<Visiting>().Where(x => x.Date_and_time == value).FirstOrDefault();
    }
    public Visiting GetVisit(int id)
    {
        return db.GetConnection().Table<Visiting>().Where(x => x.ID_Visit == id).FirstOrDefault();
    }
    public IEnumerable<Visiting> GetVisits(int id)
    {
        return db.GetConnection().Table<Visiting>().Where(x => x.ID_Visit == id);
    }
}
