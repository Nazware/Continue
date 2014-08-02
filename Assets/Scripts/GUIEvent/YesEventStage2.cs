﻿using UnityEngine;
using System.Collections;

public class YesEventStage2 : BaseEvent {
	
	[SerializeField]
	float yesSpeed = 50.0f;
	[SerializeField]
	float addTime = 0.5f;
	private float nextReturnTime = 0.0f;
	
	// Use this for initialization
	void Start () {
		nextReturnTime = Time.time + addTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextReturnTime){
			yesSpeed = yesSpeed * -1.0f;
			nextReturnTime += 0.5f;
		}
		
		this.gameObject.transform.Translate(10.0f * yesSpeed * Time.deltaTime, 0.0f, 0.0f);
	}
	
	public override void onTap()
	{
		Debug.Log("Yes");
		gameObject.SetActive(false);
		gameController.GoesNextStage();
	}
}
