
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MonoVeterinarian : MonoBehaviour
{
    [SerializeField] private TableDisplay _tabledisplay;
    [SerializeField] private TableRecord _record;
    private Service _service;
    private void Start()
    {
        _service = new Service();
        OnGetTechniques();
        OnGetRecords();
    }  
    public void OnGetTechniques()
    {
        _tabledisplay.ClearEmployee();
        var visitings = _service.GetAll<Visiting>();
        var veterinarians = _service.GetAll<Veterinarians>();


        foreach (var visiting in visitings)
        {
            Veterinarians VeterianVising = veterinarians.FirstOrDefault(p => p.ID_Doctor == visiting.Doctor_ID);
           if (VeterianVising != null)
           {
               _tabledisplay.CreateDisplay(visiting, VeterianVising);
           }
        }
    }
    public void OnGetRecords()
    {
        var owners = _service.GetAll<Owners>();
        var sick_leaves = _service.GetAll<Sick_leave>();
        var visitings = _service.GetAll<Visiting>();
        _record.SetAllVisitings(visitings);
        foreach (var sick_leave in sick_leaves)
        {
            Owners owner = owners.FirstOrDefault(p => p.ID_Owners == sick_leave.Owners_ID);
            if (owner != null)
            {
                _record.CreateRecords(owner, sick_leave);
            }
        }
    }
}
