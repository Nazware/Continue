using UnityEngine;
using System.Collections;

public class BaseEvent : MonoBehaviour {

	public GameController gameController;

	virtual public void onTap(Vector3 touchPos){
	}

	public void SetData(GameController gameController){
		this.gameController = gameController;
	}
}
