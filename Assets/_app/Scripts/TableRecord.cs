using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class TableRecord : MonoBehaviour
{
    [SerializeField] private GameObject _customerprefabs;
    [SerializeField] Transform _contentpanel;
    private GameObject[] Owner = new GameObject[99];
    private int _index;
    private string _time;
    private IEnumerable<Visiting> _allVisitings;
    public void ReceptionTime(string time)
    {
      _time = time;
    }
    public void SetAllVisitings(IEnumerable<Visiting> allVisitings)
    {
        _allVisitings = allVisitings;
    }
    public void AddRecord(Owners owner, Sick_leave sick)
    {
        GameObject newOwner = Instantiate(_customerprefabs, _contentpanel);
        Owner[_index] = newOwner;
        _index++;
        TextMeshProUGUI[] textFields = newOwner.GetComponentsInChildren<TextMeshProUGUI>();
        textFields[0].text = owner.ID_Owners.ToString();
        textFields[1].text = owner.First_name;
        textFields[2].text = owner.Phone;
        for (int i = 0; i < owner.ID_Owners; i++)
        {
            if (owner.ID_Owners == sick.Owners_ID)
            {
                textFields[3].text = sick.Diagnosis;
            }
        }
        Debug.Log(_time);
        textFields[4].text = _time;
    }
    public void CreateRecords(Owners owner, Sick_leave sick)
    {
        GameObject newOwner = Instantiate(_customerprefabs, _contentpanel);
        Owner[_index] = newOwner;
        _index++;
        TextMeshProUGUI[] textFields = newOwner.GetComponentsInChildren<TextMeshProUGUI>();
        textFields[0].text = owner.ID_Owners.ToString();
        textFields[1].text = owner.First_name;
        textFields[2].text = owner.Phone;
        for (int i = 0; i < owner.ID_Owners; i++)
        {
            if (owner.ID_Owners == sick.Owners_ID)
            {
                textFields[3].text = sick.Diagnosis;
            }
        }
        var visiting = _allVisitings.FirstOrDefault(v => v.ID_Visit == sick.Visiting_ID);
        if (visiting != null)
        {
            textFields[4].text = visiting.Date_and_time;
        }

    }
}
