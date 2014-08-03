using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CheangeBackground();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CheangeBackground(){
		int background_ID = Random.Range(1,14);
		gameObject.renderer.material = Resources.Load("Materials/background_"+background_ID) as Material;
	}
}
