using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamrstopır : MonoBehaviour
{
    public GameObject stopmenu;
  
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void spopertmı()
    {
        Time.timeScale = 0;
        stopmenu.SetActive(true);
    }

    public void homedon()
    {
        SceneManager.LoadScene("oyun");
    }

    public void devamet()
    {
        Time.timeScale = 1;
        stopmenu.SetActive(false);
    }

}
