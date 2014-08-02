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
        CreateStageObject(yesButtonPrefab, new Vector3(Random.Range(-200.0f, 200.0f),
                                                       Random.Range(-100.0f, 100.0f),
                                                       -3));
	}
	
	void Update ()
    {
	
	}
}
