using UnityEngine;
using System.Collections;

public class YesEventStage3 : BaseEvent {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public override void onTap()
	{
		gameObject.SetActive(false);
		gameController.GoesNextStage();
	}
}
