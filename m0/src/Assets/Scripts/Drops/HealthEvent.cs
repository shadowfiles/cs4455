using UnityEngine;
using System.Collections;

public class HealthEvent : DropEvent {

	public int healAmount = 5;

	PlayerHealth playerHealth;

	new public void Start () {
		base.Start ();
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	override protected bool Pickup () {
		if (playerHealth.currentHealth <= 0 || playerHealth.currentHealth >= playerHealth.startingHealth) {
			return false;
		}
		playerHealth.currentHealth += healAmount;
		if (playerHealth.currentHealth > playerHealth.startingHealth) {
			playerHealth.currentHealth = playerHealth.startingHealth;
		}
		return true;
	}
}
