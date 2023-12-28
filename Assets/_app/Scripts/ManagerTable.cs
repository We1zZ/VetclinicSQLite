using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ManagerTable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _textNameLine = new TextMeshProUGUI [4];
    [SerializeField] private string[] _nameline;
    [SerializeField] private GameObject[] _updatedb;
    [SerializeField] private Transform[] _labletransform;
    [Header("Связи")]
    [SerializeField] private MonoVeterinarian _employee;
    [SerializeField] private TableRecord _tablerecord;
    [Header("Таблицы")]
    [SerializeField] private string[] visit;
    [SerializeField] private string[] position;
    [SerializeField] private string[] Training;
    [SerializeField] private string[] Vacation;
    [SerializeField] private string[] ParticipationInTraining;
    [Header("Изменение")]
    [SerializeField] private TMP_InputField[] _inputFields;
    private Service _service;
    private Visiting currentAnimls;
    [Header("Добавления")]
    [SerializeField] private MonoVisit _visit;
    
    //Owners
    private string owner_frist_name;
    private string owner_last_name;
    private string owner_middle_name;
    private string owner_phone;
    //Animals
    private string species;
    private string breed;
    private string gender;
    private string brith;
    //List
    private string diagnose;
    private string dos;
    private string service_name;
    private int cost;
    //Veterinar
    private int _veterinar_id;
    //Visiting
    private int _visiting_id;
    private void Start()
    {
        _service = new Service();
        CreateFieldsdData();
    }
    public void VeterinarID(int id) =>_veterinar_id = id;
    public void VisitingID(int id) => _visiting_id = id;
    public void CreateVisitDisplayID(Visiting visit)=> _tablerecord.ReceptionTime(visit.Date_and_time);
    public void OnAddVisitDisplay()
    {
        owner_frist_name = _inputFields[0].text;
        owner_last_name = _inputFields[1].text;
        owner_middle_name = _inputFields[2].text;
        owner_phone = _inputFields[3].text;
        species = _inputFields[4].text;
        breed = _inputFields[5].text;
        gender = _inputFields[6].text;
        brith = _inputFields[7].text;
        diagnose = _inputFields[8].text;
        dos = _inputFields[9].text;
        service_name = _inputFields[11].text;
        Debug.Log(owner_frist_name + " " + owner_phone + " " + species + " " + breed + " " + gender);
        if (int.TryParse(_inputFields[10].text, out int cost))
            this.cost = cost;
    }
    public void OnAddVisitDisplayS()
    {
        _visit.OnAddOnwers(owner_frist_name, owner_last_name, owner_middle_name, owner_phone, species, breed, gender, brith, diagnose, dos, service_name, cost, _veterinar_id, _visiting_id);
        for (int i = 0; i < _inputFields.Length; i++)
        {
            _inputFields[i].text = "";
        }
    }
    public void UpdateEmployee()
    {
        currentAnimls.Date_and_time = _inputFields[0].text;
        currentAnimls.Date_and_time = _inputFields[1].text;
        currentAnimls.Date_and_time = _inputFields[2].text;
        currentAnimls.Date_and_time = _inputFields[3].text;

        int result = _service.Update(currentAnimls);
        _employee.OnGetTechniques();
        if (result > 0)
        {
            Debug.Log("Сотрудник успешно обновлен.");
        }
        else
        {
            Debug.Log("Ошибка обновления сотрудника.");
        }
    }
    public void CreateFieldsdData()
    {
        for (int i = 0; i < visit.Length; i++)
        {
            if(i != 9)
            {
                _updatedb[0] = Instantiate(_updatedb[0], _labletransform[i]);
                TextMeshProUGUI textFields = _updatedb[0].GetComponentInChildren<TextMeshProUGUI>();
                textFields.text = visit[i];
                _inputFields[i] = _updatedb[0].GetComponentInChildren<TMP_InputField>();
            }
            if(i == 9)
            {
                _updatedb[1] = Instantiate(_updatedb[1], _labletransform[i]);
                TextMeshProUGUI textFields = _updatedb[1].GetComponentInChildren<TextMeshProUGUI>();
                textFields.text = visit[i];
                _inputFields[i] = _updatedb[1].GetComponentInChildren<TMP_InputField>();
            }
        }
    }
}
