using UnityEngine;
using System.Collections;

public class GlassEvent : BaseEvent {

	[SerializeField]
	GameObject clackImage;

	private int tapCount = 0;
	public int breakCount = 5;
	private GameObject tapParticle;
	public UseAudio clackSE;
	public bool matFlug = false;
	// Use this for initialization
	void Start () {
		tapParticle = Resources.Load("particle/GlassCrashParticle") as GameObject;
		if(matFlug) {
			int id = Random.Range(1, 11);
			gameObject.renderer.material = Resources.Load("Materials/GlassPicture"+id) as Material;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void onTap(Vector3 touchPos)
	{
		var obj = Instantiate(clackImage, new Vector3(0.0f, 0.0f, -6.0f), clackImage.transform.rotation) as GameObject;
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
