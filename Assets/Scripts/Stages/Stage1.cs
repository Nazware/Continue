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
        CreateStageObject(yesButtonPrefab, new Vector3(0, 0, -3));
	}
	
	void Update ()
    {
	
	}
}
