using UnityEngine;
using System.Collections;

public class AmmoEvent : DropEvent {

	public int ammoAmount = 5;

	PlayerAmmo playerAmmo;

	new public void Start () {
		base.Start ();
		playerAmmo = player.GetComponent<PlayerAmmo> ();
	}
	
	override protected bool Pickup () {
		return playerAmmo.AddAmmo (ammoAmount);
	}
}
