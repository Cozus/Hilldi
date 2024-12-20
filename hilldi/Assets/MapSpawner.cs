using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSpawner : MonoBehaviour
{

    public int mapper;
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;

  




    void Start()
    {
        mapper = PlayerPrefs.GetInt("mapper");

    }



    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("mapper", mapper);

        if (mapper == 1)
        {

            map1.SetActive(true);
            map2.SetActive(false);
            map3.SetActive(false);




        }
        if (mapper == 2)
        {
           

            map1.SetActive(false);
            map2.SetActive(true);
            map3.SetActive(false);
        }

        if (mapper == 3)
        {
            map1.SetActive(false);
            map2.SetActive(false);
            map3.SetActive(true);
        }





    }

   

    public void mapsec1()
    {

        mapper = 1;

    }
    public void mapsec2()
    {
        mapper = 2;

    }

    public void mapsec3()
    {
        mapper = 3;

    }
}