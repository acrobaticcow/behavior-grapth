using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Range Detector", story: "Update Range [Detector] and assign [Target]", category: "Action", id: "cbedbf6a09184efa6f74588fca15f3a5")]
public partial class RangeDetectorAction : Action
{
	[SerializeReference] public BlackboardVariable<RangeDetector> Detector;
	[SerializeReference] public BlackboardVariable<GameObject> Target;
	protected override Status OnUpdate()
	{
		Target.Value = Detector.Value.UpdateDetector();
		return Target.Value ? Status.Success : Status.Failure;
	}

}

