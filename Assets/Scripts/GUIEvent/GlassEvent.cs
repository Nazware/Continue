using UnityEngine;
using System.Collections;

public class GlassEvent : BaseEvent {

	[SerializeField]
	GameObject clackImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void onTap(Vector3 touchPos)
	{
		Instantiate(clackImage, new Vector3(touchPos.x, touchPos.y, -1.0f), new Quaternion(90.0f, 0.0f, 0.0f, 1.0f));
		Debug.Log("Glass");
	}
}
