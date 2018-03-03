using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainComponentController : MonoBehaviour {

	protected Brain brain;

	public void SetBrain(Brain _brain)
	{
		brain = _brain;
	}
}
