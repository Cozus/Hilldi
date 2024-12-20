using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haritailerigeri : MonoBehaviour
{
    public GameObject ileridoğru;
    public GameObject geridoğru;
    public GameObject ileridoğru2;
    public GameObject geridoğru2;
    public GameObject şekermap;
    public GameObject toprakmap;
    public GameObject taşmap;
    public GameObject parayok; 
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void ilerimi()
    {
        taşmap.SetActive(true);
        toprakmap.SetActive(false);
        geridoğru.SetActive(true);
        ileridoğru2.SetActive(true);
        ileridoğru.SetActive(false);
        parayok.SetActive(false);
    }

    public void gerimi()
    {
        taşmap.SetActive(false);
        toprakmap.SetActive(true);
        geridoğru.SetActive(false);
        ileridoğru.SetActive(true);
        ileridoğru2.SetActive(false);
        parayok.SetActive(false);
    }

    public void ilerimi2()
    {
        geridoğru.SetActive(false);
        taşmap.SetActive(false);
        toprakmap.SetActive(false);
        şekermap.SetActive(true);
        ileridoğru2.SetActive(false);
        geridoğru2.SetActive(true);
        parayok.SetActive(false);

    }

    public void geridoğrumu2()
    {
        şekermap.SetActive(false);
        taşmap.SetActive(true);
        geridoğru.SetActive(true);
        geridoğru2.SetActive(false);
        ileridoğru2.SetActive(true);
        parayok.SetActive(false);
    }

}
