using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    GameObject currentStage;

    bool isPlayingStage = false;

    #region Unity Events
    void Start ()
    {
        CreateStage(1);
	}

    void Update ()
    {
        var inputs = GetInputPositions();

        if (inputs.Count > 0)
        {
            foreach (var input in inputs)
            {
                Ray ray = Camera.main.ScreenPointToRay(input);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    var obj = hit.collider.gameObject;
                    OnTouch(input, obj);
                }
            }
        }
	}
    #endregion

    void CreateStage(int stageNumber)
    {
        if (currentStage != null)
        {
            Destroy(currentStage.gameObject);
            currentStage = null;
            Resources.UnloadUnusedAssets();
        }

        currentStage = Instantiate(Resources.Load("Stages/Stage" + stageNumber)) as GameObject;
        var baseStage = currentStage.GetComponent<BaseStage>();
        baseStage.SetData(this);

        isPlayingStage = true;
    }

    void OnTouch(Vector3 touchPos, GameObject touchObject)
    {
        if (!isPlayingStage)
        {
            return;
        }

        var onTouchEvent = touchObject.GetComponent<BaseEvent>();
        if (onTouchEvent)
        {
            onTouchEvent.onTap();
        }
    }

    List<Vector3> GetInputPositions()
    {
        var inputPositions = new List<Vector3>();

        if (Input.GetMouseButtonDown(0))
        {
            inputPositions.Add(Input.mousePosition);
        }

        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                inputPositions.Add(new Vector3(touch.position.x, touch.position.y, 0.0f));
            }
        }

        return inputPositions;
    }

    public void GoesNextStage()
    {
        isPlayingStage = false;

        StopAllCoroutines();
        StartCoroutine("LoadingSample");
    }

    #region スタブ
    public IEnumerator LoadingSample()
    {
        Debug.Log("Loading...");
        yield return new WaitForSeconds(2);

        Debug.Log("Finish!");
        isPlayingStage = true;
        CreateStage(1);
    }
    #endregion
}