using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hediyesınırıvardırlan : MonoBehaviour
{
    public GameObject giftbb;
    public int giftsayısı;
    void Start()
    {
        giftsayısı = PlayerPrefs.GetInt("giftbb"); 
    }

    
    void Update()
    {
        PlayerPrefs.SetInt("giftbb", giftsayısı);

        if(giftsayısı==3)
        {
            giftbb.SetActive(false);
        }

        if(giftsayısı==6)
        {
            giftbb.SetActive(true);
        }
    }

    public void giftgit()
    {
        giftsayısı = 3;
    }

    public void sayıartır()
    {
        giftsayısı = 6;
        PlayerPrefs.SetInt("giftbb", giftsayısı);
    }
}
