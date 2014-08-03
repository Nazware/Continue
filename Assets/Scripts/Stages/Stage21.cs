using UnityEngine;
using System.Collections;

public class Stage21 : BaseStage
{
    [SerializeField]
    GameObject titlePrefab;
    [SerializeField]
    GameObject yesButtonPrefab;
    [SerializeField]
    GameObject noButtonPrefab;

    GameObject yesButton;
    GameObject noButton;

    int frame;

    void Start()
    {
        CreateStageObject(titlePrefab, new Vector3(0, 200, -2));
        yesButton = CreateStageObject(yesButtonPrefab, new Vector3(0.0f, -200.0f, -50));
        noButton = CreateStageObject(noButtonPrefab, new Vector3(0.0f, -200.0f, -2.5f));

        frame = 0;
    }

    void Update()
    {
        ++frame;
        Rotate(frame);
    }

    void Rotate(int frameCount)
    {
        yesButton.transform.localRotation = Quaternion.Euler(
            90.0f,
            180.0f,
            90.0f * Mathf.Sin(Mathf.PI * frameCount / 60.0f)
        );
    }
}
