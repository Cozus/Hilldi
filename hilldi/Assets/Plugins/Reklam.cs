using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Reklam : MonoBehaviour
{
    private InterstitialAd InterReklam;
    public string InterİD = "";
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    public void InterStatil()
    {
        InterReklam = new InterstitialAd(InterİD);
        AdRequest yeniReklam = new AdRequest.Builder().Build();
        
    }
}
