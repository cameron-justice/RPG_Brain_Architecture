using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController_Player : InputController {


    public override List<Command> CheckInput()
    {
        List<Command> commands = new List<Command>();

        commands.Add(CheckJumpAction());
        commands.Add(CheckDashAction());
        commands.Add(CheckMovementInput());

		return commands;
    }

    private Command CheckJumpAction()
    {
        if(Input.GetKeyDown(InputManager._IM.keycode_MoveJump))
        {
            return new JumpCommand(this.gameObject);
        }
        else
        {
            return null;
        }
    }

    private Command CheckDashAction()
    {
        if(Input.GetKeyDown(InputManager._IM.keycode_MoveDash))
        {
            return new DashCommand(this.gameObject);
        }
        else
        {
            return null;
        }
    }

    private Command CheckMovementInput()
    {
        Vector3 moveVector = new Vector3();

        // Check directional inputs
        if(Input.GetKey(InputManager._IM.keycode_MoveRight))
            moveVector += Vector3.right;
        if(Input.GetKey(InputManager._IM.keycode_MoveForward))
            moveVector += Vector3.forward;
        if(Input.GetKey(InputManager._IM.keycode_MoveLeft))
            moveVector += Vector3.left;
        if(Input.GetKey(InputManager._IM.keycode_MoveBack))
            moveVector += Vector3.back;

        //Check sneak and shift modifiers (Inverse of each other)
        if(Input.GetKey(InputManager._IM.keycode_MoveSneak))
        {
            moveVector *= brain.GetSneakModifier();
        }
        if(Input.GetKey(InputManager._IM.keycode_MoveSprint))
            moveVector *= brain.GetSprintModifier();


        // Apply player speed modification
        moveVector = moveVector * brain.GetSpeed();

        if(moveVector != new Vector3(0,0,0))
        {
            return new MoveCommand(this.gameObject, moveVector);
        }
        else
        {
            return null;
        }
    }
}