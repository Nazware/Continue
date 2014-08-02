using UnityEngine;
using System.Collections;

public class BaseEvent : MonoBehaviour {

	public GameController gameController;

	virtual public void onTap(){
	}

	public void SetData(GameController gameController){
		this.gameController = gameController;
	}
}
