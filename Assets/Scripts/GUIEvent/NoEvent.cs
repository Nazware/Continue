using UnityEngine;
using System.Collections;

public class NoEvent : BaseEvent {

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
        Debug.Log("No");
	}
}
