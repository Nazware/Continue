using UnityEngine;
using System.Collections;

public class Stage33 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject glassPrefab;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		CreateStageObject(yesButtonPrefab, new Vector3(-150.0f,
		                                                           -20.0f,
		                                                           -3));
		
		CreateStageObject(noButtonPrefab, new Vector3(200.0f,
		                                                         40.0f,
		                                                         -3));
		CreateStageObject(noButtonPrefab, new Vector3(0.0f,
		                                                          -40.0f,
		                                                          -3));
		CreateStageObject(noButtonPrefab, new Vector3(0.0f,
		                                                          -40.0f,
		                                                          -3));	
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -5.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -6.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -7.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -8.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
