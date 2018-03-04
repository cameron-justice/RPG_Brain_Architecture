using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController_Player : MovementController {
	

	public void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
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
