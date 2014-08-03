using UnityEngine;
using System.Collections;

public class Stage38 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject dummyYesButtonPrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject glassPrefab;

	private GameObject dummyButton;

	[SerializeField]
	float yesSpeed = 70.0f;
	[SerializeField]
	float addTime = 1.0f;
	private float nextReturnTime = 0.0f;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		CreateStageObject(yesButtonPrefab, new Vector3(150.0f,
		                                               -0.0f,
		                                               -4));
		
		CreateStageObject(noButtonPrefab, new Vector3(-150.0f,
		                                              0.0f,
		                                              -3));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -5.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -6.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -7.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -8.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -9.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -10.0f));	
		dummyButton = CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,
		                                                                  30.0f,
		                                                                  -5));
		nextReturnTime = Time.time + addTime / 2;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextReturnTime){
			yesSpeed = yesSpeed * -1.0f;
			nextReturnTime = Time.time + addTime;
		}
		dummyButton.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
	}
}
