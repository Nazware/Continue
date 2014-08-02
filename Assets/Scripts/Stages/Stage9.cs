using UnityEngine;
using System.Collections;

public class Stage9 : BaseStage {
	
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

	
	private GameObject yesButton;
	private GameObject noButton;
	private GameObject noButton2;
	private GameObject noButton3;

	[SerializeField]
	float rotateSpeed = 0.05f;

	private float thetaRad = 0.0f;


	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(0.0f, 0.0f, -3));
		
		noButton = CreateStageObject(noButtonPrefab, new Vector3(200.0f,
		                                                         40.0f,
		                                                         -3));
		noButton2 = CreateStageObject(noButtonPrefab2, new Vector3(0.0f,
		                                                           -40.0f,
		                                                           -3));
		noButton3 = CreateStageObject(noButtonPrefab2, new Vector3(0.0f,
		                                                           -40.0f,
		                                                           -3));
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

	}
	
	
}
