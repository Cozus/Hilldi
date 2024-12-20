using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArabaSpawner : MonoBehaviour
{

    public int Arabaid;
    public GameObject araba1;
    public GameObject araba2;
    public GameObject araba3;

    public Camera minicuperkamera;
    public Camera tofaskamera;
    public GameObject tofascam;
    public GameObject minicam;
    public Camera gtrkamera;
    public GameObject gtrcam;
    public GameObject seçmerkran;




    void Start()
    {
        Arabaid = PlayerPrefs.GetInt("Arabaid");

    }



    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Arabaid", Arabaid);

        if (Arabaid == 1)
        {

            araba1.SetActive(true);
            araba2.SetActive(false);
            araba3.SetActive(false);

            minicuperkamera.enabled = true;
            tofaskamera.enabled = false;
            gtrkamera.enabled = false;
            minicam.SetActive(true);
            tofascam.SetActive(false);
            gtrcam.SetActive(false);



        }
        if (Arabaid == 2)
        {
            tofaskamera.enabled = true;
            minicuperkamera.enabled = false;
            gtrkamera.enabled = false;

            tofascam.SetActive(true);
            minicam.SetActive(false);
            gtrcam.SetActive(false);

            araba1.SetActive(false);
            araba2.SetActive(true);
            araba3.SetActive(false);
        }

        if (Arabaid == 3)
        {
            tofaskamera.enabled = false;
            minicuperkamera.enabled = false;
            gtrkamera.enabled = true;

            tofascam.SetActive(false);
            minicam.SetActive(false);
            gtrcam.SetActive(true);

            araba1.SetActive(false);
            araba2.SetActive(false);
            araba3.SetActive(true);
        }





    }

    public void secmeekransil()
    {
        seçmerkran.SetActive(false);
    }

    public void arabasec1()
    {

        Arabaid = 1;

    }
    public void arabasec2()
    {
        Arabaid = 2;

    }

    public void arabasec3()
    {
        Arabaid = 3;

    }
}