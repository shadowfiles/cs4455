using UnityEngine;
using System.Collections;

public class DropManager : MonoBehaviour {
	public float spawnTime = 10f;
	public Transform[] spawnPoints;
	public GameObject drop;

	GameObject[] spawns;
	
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

		spawns = new GameObject[spawnPoints.Length];

		Spawn ();
	}
	
	void Spawn ()
	{
		for (int i = 0; i < spawnPoints.Length; i++) 
		{
			if (spawns[i] == null) 
			{
				spawns[i] = (GameObject) Instantiate (drop, spawnPoints[i].position, spawnPoints[i].rotation);
			}
		}
	}
}
