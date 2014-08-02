using UnityEngine;
using System.Collections;

public class Stage7 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;

	private GameObject yesButton;

	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(-100.0f,
		                                               -20.0f,
		                                               -3));
		CreateStageObject(noButtonPrefab, new Vector3(100.0f,
		                                              -20.0f,
		                                              -4));		                                              
		yesButton.transform.localScale = new Vector3 (10,2,5);
	}

	void Update () {

	}
}
