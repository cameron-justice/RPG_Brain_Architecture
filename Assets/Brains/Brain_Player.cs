using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain_Player : Brain {

    protected override void Start()
    {
        base.Start(); // Assigns controllers
    }

    protected override void Update()
    {
        commands = GetCommands();

        foreach(Command command in commands)
        {
            if(command != null)
                command.Execute();
        }

		commands.Clear();     
    }

    protected override List<Command> GetCommands()
    {
        List<Command> commands = new List<Command>();

        commands.AddRange(con_input.CheckInput());

        return commands;
    }
}