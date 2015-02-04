using UnityEngine;
using System.Collections;

public class InstRam : MonoBehaviour {

	public GameObject BarrettedeRam;

	public float VitesseRam = 100f;
	
	void Start () {

	}
	

	void Update () {

		//Creer une barette de ram et la lancer 
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Camera cam = Camera.main;
			GameObject theRAM = (GameObject)Instantiate (BarrettedeRam, cam.transform.position, cam.transform.rotation);
			theRAM.rigidbody.AddForce(cam.transform.forward*VitesseRam, ForceMode.Impulse);
				}
	}

}
