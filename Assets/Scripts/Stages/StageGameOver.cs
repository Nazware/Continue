using UnityEngine;
using System.Collections;

public class StageGameOver : BaseStage
{
    [SerializeField]
	GameObject titlePrefab;
    [SerializeField]
    GameObject floor;
    [SerializeField]
    GameObject perticle;

	private void Start()
    {
        var originPos = titlePrefab.transform.position;
		CreateStageObject(titlePrefab, new Vector3(originPos.x, 400, originPos.z));
        CreateStageObject(floor, new Vector3(originPos.x, originPos.y, originPos.z));
	}
	
	private void Update()
    {
        var inputs = gameController.GetInputPositions();
        if (inputs.Count > 0)
        {
            var perticleObj = Instantiate(perticle) as GameObject;
            gameController.GoesNextStage();
        }
	}
}
