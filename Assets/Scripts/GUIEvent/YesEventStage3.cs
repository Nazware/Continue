using UnityEngine;
using System.Collections;

public class YesEventStage3 : BaseEvent {

	[SerializeField]
	float yesSpeed = 100.0f;
	[SerializeField]
	float addReturnTime = 3.0f;
	//private float 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
	}

	public override void onTap()
	{
		Debug.Log("Yes");
		gameObject.SetActive(false);
		gameController.GoesNextStage();
	}
}
