using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : BrainComponentController {

	public virtual List<Command> CheckInput()
	{
		List<Command> commands = new List<Command>();

		return commands;
	}
}
