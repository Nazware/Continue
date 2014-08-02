using UnityEngine;
using System.Collections;

public class Stage4 : BaseStage 
{

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		CreateStageObject(yesButtonPrefab, new Vector3(100f, 0.0f, -3.0f));
		CreateStageObject(noButtonPrefab, new Vector3(Random.Range(-200.0f, -50.0f),
		                                              Random.Range(-130.0f, 100.0f),
		                                              -4));		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
