using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour {

	/// con_ prefix for all controller objects

	[SerializeField]
	protected AbilityController con_ability;
	[SerializeField]	
	protected InputController con_input;
	[SerializeField]	
	protected MovementController con_movement;

	// Hold commands to execute in every update
	protected List<Command> commands;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	protected virtual void Start()
	{
		if(con_ability != null)
		{
			con_ability.SetBrain(this);
		}
		
		if(con_input != null)
		{
			con_input.SetBrain(this);
		}

		if(con_movement != null)
		{
			con_movement.SetBrain(this);
		}
	}

	protected virtual void Update()
	{
		// Get all commands dependent on current actor status
		commands = GetCommands();

		// Execute all commands, still tied to this current actor
		foreach(Command command in commands)
		{
			command.Execute();
		}

		commands.Clear();
	}

	protected virtual List<Command> GetCommands()
	{
		return null;
	}

	public int GetSpeed()
	{
		return con_movement.GetSpeed();
	}

	public float GetSneakModifier()
    {
        return con_movement.GetSneakModifier();
    }

    public float GetSprintModifier()
    {
        return con_movement.GetSprintModifier();
    }

}
