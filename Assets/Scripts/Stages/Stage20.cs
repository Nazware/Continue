using UnityEngine;
using System.Collections;

public class Stage20 : BaseStage {
	
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject dummyYesButtonPrefab;
	[SerializeField]
	GameObject glassPrefab;
	
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		CreateStageObject(yesButtonPrefab, new Vector3(0.0f, 20.0f, -1.0f));
		
		CreateStageObject(dummyYesButtonPrefab, new Vector3(10.0f, 20.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-10.0f, 20.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f, 10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f, -10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f, 20.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(10.0f, 10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-10.0f, 10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(15.0f, 20.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-10.0f, 25.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(5.0f, 10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(5.0f, -10.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(5.0f, 20.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(10.0f, 15.0f, -2.0f));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-10.0f, 15.0f, -2.0f));

		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -5.0f));
	}
	
	void Update () {
		
	}
}
