using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command {

	public JumpCommand(GameObject _actor)
	{
		actor = _actor;
	}

	public override void Execute()
	{
		actor.GetComponent<MovementController>().Jump();
	}
}
