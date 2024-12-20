using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Reklam : MonoBehaviour
{
    private InterstitialAd InterReklam;
    public string InterİD = "ca-app-pub-3940256099942544/8691691433";
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
