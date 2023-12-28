using TMPro;
using UnityEngine;

public class TaibleID : MonoBehaviour
{
    [SerializeField] private ManagerTable _managerTable;
    private ServiceVisiting _servicevisiting;
    public int ID_visit;
    private GameObject _canvas;
    [SerializeField] private Status _status;
    private TextMeshProUGUI[] _tex = new TextMeshProUGUI[5];
    private void Start()
    {
        _tex = GetComponentsInChildren<TextMeshProUGUI>();
        _canvas = GameObject.Find("Visit");
        _servicevisiting = new ServiceVisiting();
        _managerTable = FindObjectOfType<ManagerTable>();;
    }
    public void GetVisitingId(int id) => ID_visit = id;
    public void Gettt()
    {
        var visit = _servicevisiting.GetVisit(ID_visit);
        if (visit != null)
        {
            int doctorId = visit.Doctor_ID;
            _managerTable.VeterinarID(doctorId);
            _managerTable.VisitingID(ID_visit);
            var s = _canvas.GetComponent<Canvas>();
            s.enabled = true;
            _managerTable.CreateVisitDisplayID(visit);
            _status.OffStatus[ID_visit] = true;
            _tex[1].text = "Занято";
        }
        else
        {
            Debug.Log("Сотрудник с ID " + ID_visit + " не найден.");
        }
    }

}
