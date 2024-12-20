using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silmek : MonoBehaviour
{
    public araba denensinmi;
    
    void Start()
    {
        
    }

  
    public void sanane()
    {

        PlayerPrefs.DeleteKey("Karakterid");

    }
}
