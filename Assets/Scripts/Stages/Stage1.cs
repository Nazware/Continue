using UnityEngine;
using System.Collections;

public class Stage1 : BaseStage
{
    [SerializeField]
	GameObject titlePrefab;
	[SerializeField]
	GameObject yesButtonPrefab;
    [SerializeField]
    GameObject noButtonPrefab;

	void Start ()
    {
		CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
		CreateStageObject(yesButtonPrefab, new Vector3(-100.0f,
		                                               -20.0f,
		                                               -3));
		CreateStageObject(noButtonPrefab, new Vector3(100.0f,
		                                              -20.0f,
		                                              -4));
	}
	
	void Update ()
    {
	
	}
}
