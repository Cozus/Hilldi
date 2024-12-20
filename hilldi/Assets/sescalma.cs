using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sescalma : MonoBehaviour
{
    public AudioSource Ses;
    public AudioClip SesClip;
    private void Awake()
    {
        foreach (Button obje in Resources.FindObjectsOfTypeAll<Button>())
        {
            obje.onClick.AddListener(() => SesCalmas());
        }
    }
    public void SesCalmas()
    {
        Ses.PlayOneShot(SesClip, 0.3f);
    }
}
