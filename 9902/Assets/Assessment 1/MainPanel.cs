using System;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject searchPanel;
    public Button searchBtn;
    public Button startBtn;

    public Camera uicamera;
    public GameObject firstPerson;
    public GameObject myCar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startBtn.onClick.AddListener(OnStartClick);
        searchBtn.onClick.AddListener(OnSearchClick);
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
