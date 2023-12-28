
using UnityEngine;

public class DataButtonUpdate : MonoBehaviour
{
    [SerializeField]private ManagerTable _managaertable;
    private void Start() => _managaertable = GetComponentInParent<ManagerTable>();
    public void OnUpdateData() => _managaertable.OnAddVisitDisplay();
}
     

