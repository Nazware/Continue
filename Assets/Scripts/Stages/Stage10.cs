using UnityEngine;
using System.Collections;

public class Stage10 : BaseStage
{
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab2;
	[SerializeField]
	GameObject noButtonPrefab3;
	[SerializeField]
	GameObject noButtonPrefab4;
	[SerializeField]
	GameObject noButtonPrefab5;
	[SerializeField]
	GameObject noButtonPrefab6;
	[SerializeField]
	GameObject noButtonPrefab7;
	[SerializeField]
	GameObject noButtonPrefab8;
	[SerializeField]
	GameObject noButtonPrefab9;
	
	[SerializeField]
	float rotateSpeed = 0.05f;
	
	private GameObject yesButton;
	private float thetaRad = 0.0f;

	void Start ()
	{
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		CreateStageObject(noButtonPrefab, new Vector3(-200.0f,
		                                              -150.0f,
		                                              -4));
		CreateStageObject(noButtonPrefab2, new Vector3(0.0f,
		                                              -150.0f,
		                                              -4));
		CreateStageObject(noButtonPrefab3, new Vector3(200.0f,
		                                              -150.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab4, new Vector3(-200.0f,
		                                               -50.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab5, new Vector3(0.0f,
		                                               -50.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab5, new Vector3(200.0f,
		                                               -50.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab4, new Vector3(-200.0f,
		                                               50.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab5, new Vector3(0.0f,
		                                               50.0f,
		                                               -4));
		CreateStageObject(noButtonPrefab5, new Vector3(200.0f,
		                                               50.0f,
		                                               -4));


		
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(-100.0f,
		                                               -20.0f,
		                                               -3));
	}
	
	void Update () {
		thetaRad += rotateSpeed;
		if(thetaRad > 360.0f){
			thetaRad = 0.0f;
		}
		
		yesButton.transform.position = new Vector3(200.0f * Mathf.Cos(thetaRad),-50.0f + (100.0f * Mathf.Sin(thetaRad)), 0.0f);
	}
}
