using UnityEngine;
using System.Collections;

public class Ram : MonoBehaviour {

	public int Degats = 35;

	VieEpita vieEnnemiEpita;

	VieSupBio vieEnnemiSupBio;



	void Start () {
		DestructionAuto();

		//ennemiEpita = GameObject.FindGameObjectsWithTag ("EnnemiEpita");
		//vieEnnemiEpita = GetComponent<VieEpita> ();
		//ennemiSupBio = GameObject.FindGameObjectsWithTag ("EnnemiSupBio");
		//vieEnnemiSupBio = GetComponent<VieSupBio> ();

	}
	

	// Detction des ennemis
	 void OnTriggerEnter (Collider other)
	{
		if (other.tag == "EnnemiEpita") {
			vieEnnemiEpita = other.gameObject.GetComponent<VieEpita> ();
			vieEnnemiEpita.vie -= (Degats/3);
			Score.score += 10/2;
			Destroy(gameObject);
				}

		if (other.tag == "EnnemiSupBio") {
			vieEnnemiSupBio = other.gameObject.GetComponent<VieSupBio> ();
			vieEnnemiSupBio.viesupbio -= (Degats/3);
			Destroy(gameObject);
			Score.score += 10/2;
				}

		}
		
	public void DestructionAuto()
	{
		Destroy (gameObject, 3f);
	}
}
