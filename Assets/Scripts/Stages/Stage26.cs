using UnityEngine;
using System.Collections;

public class Stage26 : BaseStage {

	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject dummyYesButtonPrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	[SerializeField]
	GameObject glassPrefab;
	
	private GameObject yesButton;
	private GameObject dummyButton;
	private GameObject dummyButton2;
	private GameObject noButton;
	private GameObject noButton2;
	private GameObject noButton3;
	
	[SerializeField]
	float rotateSpeed = 0.05f;
	
	private float thetaRad = 0.0f;
	void Start ()
	{
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(-150.0f,
		                                                           -20.0f,
		                                                           -3));
		dummyButton = CreateStageObject(dummyYesButtonPrefab, new Vector3(150.0f,
		                                                                  -20.0f,
		                                                                  -4));
		dummyButton2 = CreateStageObject(dummyYesButtonPrefab, new Vector3(0.0f,
		                                                                   -20.0f,
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
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -5.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -6.0f));
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -7.0f));	
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -8.0f));	
		CreateStageObject(glassPrefab, new Vector3(0.0f, 0.0f, -9.0f));	
		
	}
	
	void Update () {
		thetaRad += rotateSpeed;
		if(thetaRad > 360.0f){
			thetaRad = 0.0f;
		}
		
		noButton.transform.position = new Vector3(250.0f * -Mathf.Cos(thetaRad) -200.0f,-200.0f + (150.0f * -Mathf.Sin(thetaRad)), 0.0f);
		noButton2.transform.position = new Vector3(250.0f * Mathf.Cos(thetaRad)+200.0f, 200.0f + (150.0f * Mathf.Sin(thetaRad)), 0.0f);
		noButton3.transform.position = new Vector3(250.0f * Mathf.Cos(thetaRad),-200.0f + (150.0f * -Mathf.Sin(thetaRad)), 0.0f);
		yesButton.transform.position = new Vector3(250.0f * -Mathf.Cos(thetaRad)+200.0f, (150.0f * Mathf.Sin(thetaRad)), 0.0f);
		dummyButton.transform.position = new Vector3(250.0f * -Mathf.Cos(thetaRad), (150.0f * Mathf.Sin(thetaRad)), 0.0f);
		dummyButton2.transform.position = new Vector3(250.0f * -Mathf.Cos(thetaRad)-200.0f, (150.0f * Mathf.Sin(thetaRad)), 0.0f);
		
	}
}
