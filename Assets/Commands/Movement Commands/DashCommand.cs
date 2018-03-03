using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCommand : Command {

	public DashCommand(GameObject _actor)
	{
		actor = _actor;
	}

	public override void Execute()
	{
		actor.GetComponent<MovementController>().Dash();
	}
}
