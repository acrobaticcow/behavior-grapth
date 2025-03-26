using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Is Target Detected", story: "[Target] is in [view]", category: "Conditions", id: "4a8f0ed561577bf49eef9d7e31562307")]
public partial class IsTargetDetectedCondition : Condition
{
	[SerializeReference] public BlackboardVariable<GameObject> Target;
	[SerializeReference] public BlackboardVariable<LineOfSightDetector> View;

	public override bool IsTrue()
	{
		return View.Value.PerformDetection(Target.Value);
	}

}
