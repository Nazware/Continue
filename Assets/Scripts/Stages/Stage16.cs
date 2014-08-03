using UnityEngine;
using System.Collections;

public class Stage16 : BaseStage {
	
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
	[SerializeField]
	GameObject noButtonPrefab;
	
	
	[SerializeField]
	float yesSpeed = 80.0f;
	private float nextReturnTime = 0.0f;
	
	private GameObject yesButton;

	
	void Start () {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		
		CreateStageObject(noButtonPrefab, new Vector3(500.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(450.0f,-10.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(500.0f,-50.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(400.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(350.0f,30.0f,-4));

		CreateStageObject(noButtonPrefab, new Vector3(350.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(250.0f,-10.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(300.0f,-50.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(300.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(200.0f,30.0f,-4));

		CreateStageObject(noButtonPrefab, new Vector3(150.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(150.0f,-10.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(100.0f,-50.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(100.0f,60.0f,-4));
		CreateStageObject(noButtonPrefab, new Vector3(100.0f,30.0f,-4));

		yesButton = CreateStageObject(yesButtonPrefab, new Vector3(500.0f,-20.0f,-3));
		
		
	}
	
	void Update () {

		yesButton.transform.Translate(1.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);	
		
	}
}
