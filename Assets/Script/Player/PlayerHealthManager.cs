using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour 
{

	public int playerMaxHealth;
	public int playerCurrentHealth;

	//Reset Variables
	int ResetMoney = 0;
	int ResetPoints = 0;


	void Start () 
	{
		playerCurrentHealth = playerMaxHealth;	
	}
	

	void Update ()
	{
		
		if (playerCurrentHealth <= 0) 
		{
			gameObject.SetActive (false);

			SceneManager.LoadScene ("EndScreen");

			playerCurrentHealth = 100;

			MoneyManager.ResetCurrency (ResetMoney);

			ScoreManager.ResetScore (ResetPoints);

		}
	}

	public void HurtPlayer(int damageToGive)
	{
		playerCurrentHealth -= damageToGive;
	}

	public void SetMaxHealth()
	{
		playerCurrentHealth = playerMaxHealth;
	}


}
