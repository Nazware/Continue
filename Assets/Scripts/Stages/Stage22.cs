using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stage22 : BaseStage
{
    [SerializeField]
    GameObject titlePrefab;
    [SerializeField]
    GameObject yesButtonPrefab;
    [SerializeField]
    GameObject noButtonPrefab;

    GameObject yesButton;
    List<GameObject> noButtons = new List<GameObject>();
    List<int> frames = new List<int>();

    void Start()
    {
        CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
        yesButton = CreateStageObject(yesButtonPrefab, new Vector3(0.0f, -200.0f, -3.0f));

        noButtons.Add(CreateStageObject(noButtonPrefab, new Vector3(100.0f, -200.0f, -50.0f)));
        noButtons.Add(CreateStageObject(noButtonPrefab, new Vector3(-100.0f, -200.0f, -51.0f)));
        noButtons.Add(CreateStageObject(noButtonPrefab, new Vector3(0.0f, -200.0f, -52.0f)));

        frames.Add(Random.Range(0, 59));
        frames.Add(Random.Range(0, 59));
        frames.Add(Random.Range(0, 59));
    }

    void Update()
    {
        for (int i = 0; i < frames.Count; i++)
        {
            ++frames[i];
            Rotate(i);
        }
    }

    void Rotate(int index)
    {
        noButtons[index].transform.localRotation = Quaternion.Euler(
            90.0f,
            180.0f,
            90.0f * Mathf.Sin(Mathf.PI * frames[index] / 60.0f)
        );
    }
}
