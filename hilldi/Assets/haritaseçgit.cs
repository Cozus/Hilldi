using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haritaseçgit : MonoBehaviour
{
    public GameObject arabasecgit;
    public GameObject haritasecgel;
  
    public void salam()
    {
        arabasecgit.SetActive(false);
        haritasecgel.SetActive(true);
    }

    
    public void sosis()
    {
        arabasecgit.SetActive(true);
        haritasecgel.SetActive(false);
    }
}
