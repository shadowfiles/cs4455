using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class PlayerRootMotion : MonoBehaviour {
	private Animator anim;
	private CharacterController character;
	void Start () {
		character = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}

	void OnAnimatorMove() {
		Vector3 movement = new Vector3(0f, anim.GetFloat("jumpSpeed"), 0f) + transform.forward * anim.GetFloat("speed");
		character.Move (movement * Time.deltaTime);
	}
}
