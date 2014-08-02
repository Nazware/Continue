using UnityEngine;
using System.Collections;

public class BaceEvent : MonoBehaviour {

	public GameController gameController;

	virtual public void onTap(){
	}

	public void SetData(GameController gameController){
		this.gameController = gameController;
	}
}
