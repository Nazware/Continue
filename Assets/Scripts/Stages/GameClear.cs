using UnityEngine;
using System.Collections;

public class GameClear : BaseStage
{
	[SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject floor;
	[SerializeField]
	GameObject perticle;
	
	[SerializeField]
	GameObject illust1;
	[SerializeField]
	GameObject illust2;
	[SerializeField]
	GameObject illust3;
	[SerializeField]
	GameObject illust4;
	[SerializeField]
	GameObject illust5;
	
	[SerializeField]
	GameObject yesButtonPrefab;

	private GameObject illustPos;

	private void Start()
	{
		
		CreateStageObject(yesButtonPrefab, new Vector3(350.0f,290.0f,-4));

		CreateStageObject(illust1, new Vector3(-300,-300,-3));
		CreateStageObject(illust2, new Vector3(-150,-300,-3));
		CreateStageObject(illust3, new Vector3(0,-300,-3));
		CreateStageObject(illust4, new Vector3(150,-300,-3));
		CreateStageObject(illust5, new Vector3(300,-300,-3));

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
