using UnityEngine;
using System.Collections;

public class Stage15 : BaseStage {
	
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;

	
	[SerializeField]
	float yesSpeed = 80.0f;
	[SerializeField]
	float addTime = 1.0f;
	private float nextReturnTime = 0.0f;
	
	private GameObject yesButton;
	
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
		

	}
	
	void Update () {
		if(Time.time > nextReturnTime){
			yesSpeed = yesSpeed * -1.0f;
			nextReturnTime = Time.time + addTime;
		}
		yesButton.transform.Translate(-20.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);	
		
	}
}
