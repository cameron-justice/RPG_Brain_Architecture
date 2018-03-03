using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command {

    private Vector3 moveVector;

    public MoveCommand(GameObject _actor, Vector3 _moveVector)
    {
        actor = _actor;
        moveVector = _moveVector;
    }

    public override void Execute()
    {
        actor.transform.Translate(moveVector * Time.deltaTime);
    }

}