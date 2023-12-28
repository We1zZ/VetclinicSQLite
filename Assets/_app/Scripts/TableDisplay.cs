using TMPro;
using UnityEngine;

public class TableDisplay : MonoBehaviour
{
    public GameObject visitPrefab;
    public Transform contentPanel;
    private GameObject[] Visit = new GameObject[99];
    private int index;
    [Header("Сохранения")]
    [SerializeField] Status _status;
    
    public void CreateDisplay(Visiting visit, Veterinarians veterinar)
    {
        GameObject newEmployee = Instantiate(visitPrefab, contentPanel);
        Visit[index] = newEmployee;
        newEmployee.GetComponent<TaibleID>().GetVisitingId(visit.ID_Visit);
        index++;
        TextMeshProUGUI[] textFields = newEmployee.GetComponentsInChildren<TextMeshProUGUI>();
        textFields[0].text = visit.ID_Visit.ToString();
        textFields[2].text = visit.Date_and_time.ToString();
        textFields[3].text = veterinar.Last_name;
            if (_status.OffStatus[index] == true)
            {
                textFields[1].text = "Занято";
            }
            else
            {
                textFields[1].text = "Свободно";
            }
  


    }
    public void ClearEmployee()
    {
       foreach(GameObject e in Visit)
        {
           Destroy(e);
        }
    }
}