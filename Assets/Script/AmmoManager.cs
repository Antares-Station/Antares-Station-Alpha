using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

	public static int CurrentAmmo;

	Text text;


	void Start () 
	{
		text = GetComponent<Text> ();

	}

	void Update () 
	{

		if (CurrentAmmo < 0)
			CurrentAmmo = 0;

		text.text = "" + CurrentAmmo;


	}
		

	public static void AmmoCount (int Ammo)
	{
		CurrentAmmo = Ammo;
	}
		
}
