using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammopickup : MonoBehaviour {

	public int Ammopoints;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "player")



			//playermovement.AmmoAmount (Ammopoints);
			Destroy (gameObject);

	}
}
