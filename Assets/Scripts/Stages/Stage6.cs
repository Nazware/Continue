using UnityEngine;
using System.Collections;

public class Stage6 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab2;
	
	[SerializeField]
	float noSpeed = 80.0f;
	[SerializeField]
	float addTime = 1.0f;
	private float nextReturnTime = 0.0f;
	
	private GameObject noButton;
	private GameObject noButton2;

	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		CreateStageObject(yesButtonPrefab, new Vector3(0.0f, 0.0f, -3));

		noButton = CreateStageObject(noButtonPrefab, new Vector3(200.0f,
		                                                         40.0f,
		                                                         -3));
		noButton2 = CreateStageObject(noButtonPrefab2, new Vector3(0.0f,
		                                                         -40.0f,
		                                                          -3));
		nextReturnTime = Time.time + addTime;
	}

	void Update () {
		if(Time.time > nextReturnTime){
			noSpeed = noSpeed * -1.0f;
			nextReturnTime = Time.time + addTime;
		}
		noButton.transform.Translate(10.0f * noSpeed * Time.deltaTime, 0.0f, 0.0f);	
		noButton2.transform.Translate(10.0f * noSpeed * Time.deltaTime * -1, 0.0f, 0.0f);	
	}
	

}
