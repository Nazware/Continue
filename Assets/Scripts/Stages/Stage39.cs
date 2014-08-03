using UnityEngine;
using System.Collections;

public class Stage39 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		CreateStageObject(yesButtonPrefab, new Vector3(150.0f,
		                                               -0.0f,
		                                               -4));
		
		CreateStageObject(noButtonPrefab, new Vector3(-150.0f,
		                                              0.0f,
		                                              -3));	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
