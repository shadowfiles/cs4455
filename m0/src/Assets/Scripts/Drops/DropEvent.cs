using UnityEngine;
using System.Collections;

public abstract class DropEvent : MonoBehaviour {

	protected GameObject player;
	
	protected void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (transform.position.y < 0.5) {
			transform.position += new Vector3 (0, 0.5f, 0);
		}
	}

	abstract protected bool Pickup ();

	protected void OnTriggerEnter (Collider other) {
		if(other.gameObject == player && Pickup())
		{
			Destroy (gameObject);
		}
	}


}
