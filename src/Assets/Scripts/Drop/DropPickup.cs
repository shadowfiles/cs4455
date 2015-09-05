using UnityEngine;
using System.Collections;

public class DropPickup : MonoBehaviour {

	GameObject player;
	PlayerAmmo playerAmmo;

	public int ammo = 5;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerAmmo = player.GetComponent<PlayerAmmo> ();

		transform.position += new Vector3 (0, .5f, 0);
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			if (playerAmmo.AddAmmo(ammo))
			{
				Destroy(gameObject);
			}
		}
	}
}
