using UnityEngine;
using System.Collections;

public class Stage14 : BaseStage {
	
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject glassPrefab;

	[SerializeField]
	float rotateSpeed = 0.05f;
	
	private GameObject yesButton;
	private float thetaRad = 0.0f;

	private GameObject noButton;
	private GameObject noButton2;
	private GameObject noButton3;
	private GameObject noButton4;
	private GameObject noButton5;
	
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		noButton = CreateStageObject(noButtonPrefab, new Vector3(-220.0f,
		                                                         -160.0f,
		                                                         -4));
		noButton2 = CreateStageObject(noButtonPrefab, new Vector3(220.0f,
		                                                          -160.0f,
		                                                          -4));
		noButton3 = CreateStageObject(noButtonPrefab, new Vector3(0.0f,
		                                                          -50.0f,
		                                                          -4));
		noButton4 = CreateStageObject(noButtonPrefab, new Vector3(-220.0f,
		                                                          60.0f,
		                                                          -4));
		noButton5 = CreateStageObject(noButtonPrefab, new Vector3(220.0f,
		                                                          60.0f,
		                                                          -4));
		
		
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(-100.0f,
		                                                           -20.0f,
		                                                           -3));


		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -5.0f));
	}
	
	void Update () {
		thetaRad += rotateSpeed;
		if(thetaRad > 360.0f){
			thetaRad = 0.0f;
		}
		
		yesButton.transform.position = new Vector3(200.0f * -Mathf.Cos(thetaRad),-50.0f + (100.0f * Mathf.Sin(thetaRad)), 0.0f);
		

	}
}
