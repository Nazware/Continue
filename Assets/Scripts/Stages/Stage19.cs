using UnityEngine;
using System.Collections;

public class Stage19 : BaseStage
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
		
		CreateStageObject(yesButtonPrefab, new Vector3(0.0f,0.0f,-3));

		CreateStageObject(dummyYesButtonPrefab, new Vector3(-300.0f,-200.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(-300.0f,-100.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-300.0f,0.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(-300.0f,100.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-300.0f,200.0f,-3));
		
		CreateStageObject(noButtonPrefab, new Vector3(-150.0f,-200.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-150.0f,-100.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(-150.0f,0.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(-150.0f,100.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(-150.0f,200.0f,-3));
		
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,-200.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(0.0f,-100.0f,-3));

		CreateStageObject(noButtonPrefab, new Vector3(0.0f,100.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,200.0f,-3));

		
		CreateStageObject(noButtonPrefab, new Vector3(150.0f,-200.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(150.0f,-100.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(150.0f,0.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(150.0f,100.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(150.0f,200.0f,-3));
		
		CreateStageObject(dummyYesButtonPrefab, new Vector3(300.0f,-200.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(300.0f,-100.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(300.0f,0.0f,-3));
		CreateStageObject(noButtonPrefab, new Vector3(300.0f,100.0f,-3));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(300.0f,200.0f,-3));
	}
	
	void Update () {

	}
}
