using UnityEngine;
using System.Collections;

public class Stage8 : BaseStage {
	
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	
	[SerializeField]
	float yesSpeed = 50.0f;
	[SerializeField]
	float addTime = 1.0f;
	private float nextReturnTime = 0.0f;
	
	private GameObject yesButton;
	private GameObject noButton;
	private GameObject noButton2;
	
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(200.0f,
		                                                           -60.0f,
		                                                           -3));
		noButton = CreateStageObject(noButtonPrefab, new Vector3(-200.0f,
		                                              -60.0f,
		                                              -4));
		noButton2 = CreateStageObject(noButtonPrefab, new Vector3(100.0f,
		                                              -60.0f,
		                                              -4));

		
		noButton.transform.localScale = new Vector3 (20,100,50);	                                              
		noButton2.transform.localScale = new Vector3 (20,100,50);

		nextReturnTime = Time.time + addTime;
	}
	
	void Update () {
		if(Time.time > nextReturnTime){
			yesSpeed = yesSpeed * -1.0f;
			nextReturnTime = Time.time + addTime;
		}
		yesButton.transform.Translate(6.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);	
	}
}
