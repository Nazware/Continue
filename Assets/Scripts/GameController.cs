using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameController : MonoBehaviour
{
    GameObject currentStage;
    int stageNumber = 7;

    bool isPlayingStage = false;

    #region Unity Events
    void Start ()
    {
        CreateStage(stageNumber);
        isPlayingStage = true;
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

    int CreateStage(int stageNumber)
    {
        if (currentStage != null)
        {
            Destroy(currentStage.gameObject);
            currentStage = null;
            Resources.UnloadUnusedAssets();
        }

        var stagePrefab = Resources.Load("Stages/Stage" + stageNumber);
        if (!stagePrefab)
        {
            stageNumber = 1;
            stagePrefab = Resources.Load("Stages/Stage1");
        }

        currentStage = Instantiate(stagePrefab) as GameObject;
        if (currentStage)
        {
            var baseStage = currentStage.GetComponent<BaseStage>();
            baseStage.SetData(this);
        }

        return stageNumber;
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
            onTouchEvent.onTap(touchPos);
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
        StartCoroutine(LoadingSample(() =>
            {
                isPlayingStage = true;

                stageNumber = CreateStage(stageNumber + 1);
            }
        ));
    }

    public void GameOver()
    {
        isPlayingStage = false;

        StopAllCoroutines();
        StartCoroutine(LoadingSample(() =>
            {
                isPlayingStage = true;

                stageNumber = CreateStage(1);
            }
        ));
    }

    #region スタブ
    public IEnumerator LoadingSample(Action onComplete)
    {
        Debug.Log("Loading...");
        yield return new WaitForSeconds(1);

        Debug.Log("Finish!");
        onComplete();
    }
    #endregion
}