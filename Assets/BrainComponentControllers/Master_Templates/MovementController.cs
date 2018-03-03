using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : BrainComponentController {

	[SerializeField]
	protected int speed = 5;
	[SerializeField]
	protected int jumpForce = 400;

	[SerializeField]
	protected float fallMultiplier = 2.5f;
	[SerializeField]
	protected float lowJumpMultiplier = 2f;
	[SerializeField]
	protected float dashMultiplier = 100f;
	[SerializeField]
	protected float sneakModifier = 0.5f;
	[SerializeField]
	protected float sprintModifier = 2f;
	[SerializeField]
	protected float maxFallVelocity = 50f;

	protected Rigidbody rb;
	protected Transform tr;

	public void Start()
	{
		rb = GetComponent<Rigidbody>();
		tr = GetComponent<Transform>();
	}

	public virtual void Jump(){}
	public virtual void Dash(){}

	public int GetSpeed()
	{
		return speed;
	}

	public float GetSneakModifier()
	{
		return sneakModifier;
	}

	public float GetSprintModifier()
	{
		return sprintModifier;
	}
}