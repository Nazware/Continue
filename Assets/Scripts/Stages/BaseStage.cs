using UnityEngine;
using System.Collections;

public class BaseStage : MonoBehaviour {

	public GameController gameController;



	public void SetData(GameController gameController)
    {
		this.gameController = gameController;
	}

    protected GameObject CreateStageObject(GameObject parent, Vector3 pos)
    {
        var obj = Instantiate(parent, pos, parent.transform.rotation) as GameObject;
        if (obj)
        {
            var baseEvent = obj.GetComponent<BaseEvent>();
            if (baseEvent)
            {
                baseEvent.SetData(this.gameController);
            }

            obj.transform.parent = transform;
        }

        return obj;
    }
}
