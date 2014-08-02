using UnityEngine;
using System.Collections;

public class YesEvent : BaseEvent {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

	public override void onTap(Vector3 touchPos)
    {
        gameObject.SetActive(false);
        gameController.GoesNextStage();
	}
}
