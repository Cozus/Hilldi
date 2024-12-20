using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class ilerimigerimi : MonoBehaviour
{
    public GameObject ileri1;
    public GameObject geri1;
    public GameObject ileri2;
    public GameObject geri2;
    public GameObject arabaresmi1;
    public GameObject arabaresmi2;
    public GameObject arabaresmi3;
    public GameObject parayok;
    
    public int arabasecmi;

    void Start()
    {
        arabasecmi = PlayerPrefs.GetInt("arabasecmi");
    }


    void Update()
    {

        PlayerPrefs.SetInt("arabasecmi", arabasecmi);
      if(arabasecmi==1)
      {
            ileri1.SetActive(false);
            geri1.SetActive(true);
            ileri2.SetActive(true);
            geri2.SetActive(false);
            arabaresmi1.SetActive(false);
            arabaresmi2.SetActive(true);
            arabaresmi3.SetActive(false);
            parayok.SetActive(false);
        }
        if (arabasecmi == 2)
        {
            ileri1.SetActive(true);
            geri1.SetActive(false);
            ileri2.SetActive(false);
            geri2.SetActive(false);
            arabaresmi1.SetActive(true);
            arabaresmi2.SetActive(false);
            arabaresmi3.SetActive(false);
            parayok.SetActive(false);
        }
        if (arabasecmi == 3)
        {
            ileri1.SetActive(false);
            geri1.SetActive(false);
            ileri2.SetActive(false);
            geri2.SetActive(true);
            arabaresmi1.SetActive(false);
            arabaresmi2.SetActive(false);
            arabaresmi3.SetActive(true);
            parayok.SetActive(false);
        }
        if (arabasecmi == 4)
        {
            ileri1.SetActive(false);
            geri1.SetActive(true);
            ileri2.SetActive(true);
            geri2.SetActive(false);
            arabaresmi1.SetActive(false);
            arabaresmi2.SetActive(true);
            arabaresmi3.SetActive(false);
            parayok.SetActive(false);
        }


    }

    public void ileri1mi()
    {

        arabasecmi = 1;

    }
    public void geri1mi()
    {
        arabasecmi = 2;
    }
    public void ileri2mi()
    {
        arabasecmi = 3;
    }
    public void geri2mi()
    {
        arabasecmi = 4;
    }

    public void silartıkbe()
    {
        arabasecmi = 5;
    }

}
