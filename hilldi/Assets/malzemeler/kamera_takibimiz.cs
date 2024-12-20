using UnityEngine;
using System.Collections;

public class kamera_takibimiz : MonoBehaviour {

	// Use this for initialization
    public Transform nesne;
	public Transform esya;
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
        Vector3 konum = new Vector3(nesne.position.x, nesne.position.y, transform.position.z);
        transform.position = konum;

		Vector3 yer = new Vector3(esya.position.x, esya.position.y, transform.position.z);
		transform.position = yer;
	}
}
