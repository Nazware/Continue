using UnityEngine;
using System.Collections;

public class BaseScene : MonoBehaviour {

	public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetData(GameController gameController){
		this.gameController = gameController;
	}
}
