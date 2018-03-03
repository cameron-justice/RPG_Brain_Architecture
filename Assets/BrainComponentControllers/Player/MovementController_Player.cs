using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController_Player : MovementController {
	

	public void Start()
	{
		base.Start();
	}

	void Update()
	{
		// Lock rotation so player is alwas upright
		if(tr.rotation.x != 0 || tr.rotation.z != 0)
			tr.rotation = new Quaternion(0, tr.rotation.y, 0, Quaternion.identity.w);

		// Apply jump falloff
		if(rb.velocity.y < 0)
		{
			rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		}

		if(rb.velocity.y < -maxFallVelocity)
		{
			rb.velocity = new Vector3(rb.velocity.x, -maxFallVelocity, rb.velocity.z);
		}
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		rb.isKinematic = false;
	}

	public override void Jump()
	{
		rb.AddForce(jumpForce * Vector3.up);
	}

	public override void Dash()
	{
		rb.AddForce(Vector3.forward * brain.GetSpeed() * dashMultiplier);
	}
}
