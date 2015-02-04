using UnityEngine;
using System.Collections;

public class VieSupBio : MonoBehaviour {
	
	public int viemax = 100;
	public int viesupbio;
	
	
	bool Mort;
	SupBioDeplacement deplacement;
	// Use this for initialization
	void Start () {
		viesupbio = viemax;
		
		deplacement = GetComponent<SupBioDeplacement> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (viesupbio <= 0f && !Mort)
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