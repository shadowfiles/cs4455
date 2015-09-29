using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {

	public float jumpSpeed = 6.0f;
	public float gravity = 20.0f;
	public float acceleration = 1.0f;
	public float maxSpeed = 5.0f;
	public float rotationSpeed = 3.0f;

	private Animator anim;
	private float speed = 0f;
	private Vector3 velocity = Vector3.zero; 
	private CharacterController character;
	private Collider collider;
	private bool powered = true;

	void Start() {
		anim = GetComponent<Animator> ();
		character = GetComponent<CharacterController> ();
		collider = GetComponent<Collider> ();
	}

	void Update () {
		if (Input.GetAxis ("Power") != 0f)
			powered = Input.GetAxis ("Power") > 0;

		bool grounded = Physics.CheckCapsule(collider.bounds.center, new Vector3(collider.bounds.center.x, collider.bounds.min.y-0.1f, collider.bounds.center.z), 0.18f, ~(1 << 8));

		if (powered && grounded) {
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");
			if (h != 0f) 
				transform.Rotate (0, h * rotationSpeed, 0);
			if ((v > 0f && speed < maxSpeed) || (v < 0f && speed > -maxSpeed / 2.0)) 
				speed += v * acceleration * Time.deltaTime;
			else {
				speed -= 2 * acceleration * Time.deltaTime;
				if (speed < 0f) 
					speed = 0f;
			}

			velocity = transform.forward * speed;

			if (Input.GetAxis ("Jump") > 0f) {
				velocity.y = jumpSpeed + speed / 2.0f;
				grounded = false;
			} 
		} else if (grounded && !powered) {
			speed -= 3 * acceleration * Time.deltaTime;
			if (speed < 0f) 
				speed = 0f;
			velocity = transform.forward * speed;
		}

		anim.SetBool ("powered", powered);
		anim.SetBool ("grounded", grounded);
		anim.SetFloat ("speed", Math.Abs(speed));
		anim.SetFloat ("jumpSpeed", velocity.y);

		// character.Move (new Vector3 (0f, velocity.y, 0f) * Time.deltaTime);
		// character.Move (velocity * Time.deltaTime);
		if (grounded)
			velocity.y = 0f;
		else
			velocity.y -= gravity * Time.deltaTime;
	}
}
