using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour 
{
	public int pointstoadd;
	public int EnemyMaxHealth;
	public int EnemyCurrentHealth;
	public float RandomDrop;

	public bool drops;
	public GameObject drop;
	public GameObject drop2;

	void Start () 
	{
		EnemyCurrentHealth = EnemyMaxHealth;	
	}
	

	void Update ()
	{
		
		if (EnemyCurrentHealth <= 0) 
		{
			//gameObject.SetActive (false);
			//Do everything you want with this part, but before destroying the enemy, add this:

			Destroy(gameObject);

			//RandomDrop = Random.Range (1f, 2f);


				Instantiate (drop, transform.position, transform.rotation);
				Instantiate (drop2, transform.position, transform.rotation);

			ScoreManager.AddPoints (pointstoadd);

			GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;

		}
			
	}

	public void makeDead()
	{

	}

	public void BulletDamage(int damageToGive)
	{
		EnemyCurrentHealth -= damageToGive;
	}

	public void SetMaxHealth()
	{
		EnemyCurrentHealth = EnemyMaxHealth;
	}



}
