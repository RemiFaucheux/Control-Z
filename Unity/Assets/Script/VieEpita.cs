using UnityEngine;
using System.Collections;

public class VieEpita : MonoBehaviour {

	public int viemax = 100;
	public int vie;


	bool Mort;
	EpitaDeplacement deplacement;
	// Use this for initialization
	void Start () {
		vie = viemax;

		deplacement = GetComponent<EpitaDeplacement> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (vie <= 0f && !Mort)
		{
			Death ();
		}
	}

	 


		
	void Death()
	{
		Mort = true;
		deplacement.enabled = false;
		Destroy(gameObject, 0f);
		}
}
