using UnityEngine;
using System.Collections;

public class Stage17 : BaseStage
{
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject dummyYesButtonPrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	
	void Start ()
	{
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		CreateStageObject(yesButtonPrefab, new Vector3(-150.0f,
		                                               -20.0f,
		                                               -3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(150.0f,
		                                                    -20.0f,
		                                                    -4));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,
		                                                    -20.0f,
		                                                    -4));
	}
	
	void Update ()
	{
		
	}
}
