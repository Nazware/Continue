using UnityEngine;
using System.Collections;

public class NoEvent : BaseEvent {

	public UseAudio gameOverSE;

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
		gameOverSE.sePlay();
        //gameObject.SetActive(false);
        gameController.GameOver();
	}
}
