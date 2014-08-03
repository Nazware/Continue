using UnityEngine;
using System.Collections;

public class DummyYesEvent : BaseEvent {
	
	private GameObject tapParticle;
	// Use this for initialization
	void Start ()
	{
		tapParticle = Resources.Load("particle/Particle System") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public override void onTap(Vector3 touchPos)
	{
		Instantiate(tapParticle, gameObject.transform.position, tapParticle.transform.rotation);
		gameObject.SetActive(false);
	}
}
