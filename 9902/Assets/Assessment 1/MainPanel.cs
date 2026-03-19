using System;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public GameObject startPanel;
    public Button startBtn;

    public GameObject searchPanel;
    public Button searchBtn;
    public Button fuelBtn;
    public Button stateBtn;

    public GameObject fuelPanel;
    public GameObject statePanel;
    public Button close1Btn;
    public Button close2Btn;

    public Camera uicamera;
    public GameObject firstPerson;
    public GameObject myCar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startBtn.onClick.AddListener(OnStartClick);
        searchBtn.onClick.AddListener(OnSearchClick);
        fuelBtn.onClick.AddListener(() => { 
            searchPanel.SetActive(false);
            fuelPanel.SetActive(true);
        });
        stateBtn.onClick.AddListener(() =>
        {
            statePanel.SetActive(true);
            searchPanel.SetActive(false);
        });

        close1Btn.onClick.AddListener(() => {
            fuelPanel.SetActive(false);
        });
        close2Btn.onClick.AddListener(() => {
            statePanel.SetActive(false);
        });
    }

    private void OnSearchClick()
    {
        searchPanel.SetActive(false);
        myCar.GetComponent<Outline>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnStartClick()
    {
        uicamera.gameObject.SetActive(false);
        startPanel.SetActive(false);
        firstPerson.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            searchPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
