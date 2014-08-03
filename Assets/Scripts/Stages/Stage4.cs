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
	[SerializeField]
	float rotateSpeed = 0.05f;

	private GameObject yesButton;
	private float thetaRad = 0.0f;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(100f, 0.0f, -3.0f));
		CreateStageObject(noButtonPrefab, new Vector3(-200.0f,
		                                              -100.0f,
		                                              -2));	
		CreateStageObject(noButtonPrefab, new Vector3(210.0f,
		                                              100.0f,
		                                              -2));		
	}
	
	// Update is called once per frame
	void Update () {
		thetaRad += rotateSpeed;
		if(thetaRad > 360.0f){
			thetaRad = 0.0f;
		}

		yesButton.transform.position = new Vector3(250.0f * Mathf.Cos(thetaRad),-50.0f + (150.0f * Mathf.Sin(thetaRad)), 0.0f);
	}
}
