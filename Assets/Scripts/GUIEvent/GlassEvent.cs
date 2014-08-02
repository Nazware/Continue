using UnityEngine;
using System.Collections;

public class GlassEvent : BaseEvent {

	[SerializeField]
	GameObject clackImage;

	private int tapCount = 0;
	public int breakCount = 5;
	private GameObject tapParticle;
	public UseAudio clackSE;
	// Use this for initialization
	void Start () {
		tapParticle = Resources.Load("particle/GlassBreakParticle") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void onTap(Vector3 touchPos)
	{
		var obj = Instantiate(clackImage, new Vector3(0.0f, 0.0f, -1.0f), clackImage.transform.rotation) as GameObject;
		obj.transform.parent = gameObject.transform;
		clackSE.sePlay();
		tapCount++;
		if(tapCount == breakCount) {
			clackSE.stopPlay();
			Instantiate(tapParticle, gameObject.transform.position, tapParticle.transform.rotation);
			Destroy(this.gameObject);
		}
	}
}
