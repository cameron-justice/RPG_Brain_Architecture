# RPG_Brain_Architecture

I love RPGs, and it is my dream to make one eventually.

I love to plan. It is my dream to one day plan everything.

So instead of planning an RPG, I'm planning a plan for an RPG.

This is the architecture for a "brain" structure, in which a brain (master controller) links into parts of the actor (movement, actions, etc.) in order to encapsulate control into as narrow a view as possible. This structure is best for my design as it allows for AI control to be adapted trivially from the same structure as the player.

This architecture relies heavily on the Command patterm (Thanks, [Bob!](http://www.gameprogrammingpatterns.com/command.html)), and a top-down structure where all communication between actors must pass through the brains.
