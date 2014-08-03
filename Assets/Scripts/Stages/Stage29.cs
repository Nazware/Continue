using UnityEngine;
using System.Collections;

public class Stage29 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject dummyYesButtonPrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;

	private GameObject yesButton;
	private GameObject dummyButton;
	private GameObject dummyButton2;
	private GameObject noButton;
	private GameObject noButton2;
	private GameObject noButton3;
	
	
	[SerializeField]
	float yesSpeed = 70.0f;
	[SerializeField]
	float addTime = 1.0f;
	private float nextReturnTime = 0.0f;

	// Use this for initialization
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(-150.0f,
		                                                           0.0f,
		                                                           -3));
		dummyButton = CreateStageObject(dummyYesButtonPrefab, new Vector3(150.0f,
		                                                                  -20.0f,
		                                                                  -4));
		dummyButton2 = CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,
		                                                                   30.0f,
		                                                                   -4));
		CreateStageObject(dummyYesButtonPrefab, new Vector3(Random.Range(0.0f, 200.0f),
		                                                    Random.Range(-200.0f, 200.0f),
		                                                    -4));
		
		noButton = CreateStageObject(noButtonPrefab, new Vector3(200.0f,
		                                                         40.0f,
		                                                         -3));
		noButton2 = CreateStageObject(noButtonPrefab, new Vector3(0.0f,
		                                                          -40.0f,
		                                                          -3));
		noButton3 = CreateStageObject(noButtonPrefab, new Vector3(0.0f,
		                                                          -40.0f,
		                                                          -3));	
		nextReturnTime = Time.time + addTime / 2;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextReturnTime){
			yesSpeed = yesSpeed * -1.0f;
			nextReturnTime = Time.time + addTime;
		}
		noButton.transform.Translate(5.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
		noButton2.transform.Translate(30.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
		noButton3.transform.Translate(20.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
		
		yesButton.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
		
		dummyButton.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
		dummyButton2.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);	
	}
}
