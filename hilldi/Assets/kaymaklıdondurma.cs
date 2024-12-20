using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaymaklıdondurma : MonoBehaviour
{
    
    public int dondurkey;
    public GameObject dondurmalı;


    void Start()
    {
        dondurkey = PlayerPrefs.GetInt("dondurkey");
    }


    void Update()
    {
        PlayerPrefs.SetInt("dondurkey", dondurkey);

        if (dondurkey == 1)
        {
            Time.timeScale = 0;
            dondurmalı.SetActive(false);

        }
   

    }
    public void dondur()
    {
        dondurkey = 1;
    }

    public void cozmek()
    {
        Time.timeScale = 1;
    }
}
