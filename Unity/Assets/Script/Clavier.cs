using UnityEngine;
using System.Collections;

public class Clavier : MonoBehaviour {

	public int Degats = 50;
	
	VieEpita vieEnnemiEpita;
	
	VieSupBio vieEnnemiSupBio;

	bool attaking;
	bool EpitaOnRange;
	bool SupBioOnRange;

	void Update (){
		if (Input.GetKeyDown (KeyCode.Mouse0))
						attaking = true;
				else
						attaking = false;

	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "EnnemiEpita")
						EpitaOnRange = true;
				else
						EpitaOnRange = false;
		if (other.tag == "EnnemiSupBio")
						SupBioOnRange = true;
				else
						SupBioOnRange = false;

	}
	void Attaque () {





	}

}
