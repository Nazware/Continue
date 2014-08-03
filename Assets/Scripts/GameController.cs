using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameController : MonoBehaviour
{
    GameObject currentStage;
    int stageNumber = 1;

    GameObject countdown;

    bool isPlayingStage = false;

	public GameObject backgroundController;

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
            if (countdown != null)
            {
                Destroy(countdown.gameObject);
                countdown = null;
            }

            Resources.UnloadUnusedAssets();
        }

        var stagePrefab = Resources.Load("Stages/Stage" + stageNumber);
        if (!stagePrefab)
        {
            stageNumber = 0;
			stagePrefab = Resources.Load("Stages/GameClear");
        }


        currentStage = Instantiate(stagePrefab) as GameObject;
        if (currentStage)
        {
            var baseStage = currentStage.GetComponent<BaseStage>();
            baseStage.SetData(this);

            var timer = Instantiate(Resources.Load("CountdownTimer")) as GameObject;
            if (timer)
            {
                countdown = timer;

                var controller = countdown.GetComponent<CountdownController>();
                controller.Initialize(baseStage.countdownSeconds, this);
            }
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

    public List<Vector3> GetInputPositions()
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
				backgroundController.GetComponent<BackgroundController>().CheangeBackground();
            }
        ));
    }

    public void GameOver()
    {
        if (!isPlayingStage)
        {
            return;
        }

		GameStatus.Instance().score = 0;

        isPlayingStage = false;

        StopAllCoroutines();
        StartCoroutine(LoadingSample(() =>
            {
                isPlayingStage = true;

                stageNumber = 0;

                if (currentStage != null)
                {
                    Destroy(currentStage.gameObject);
                    currentStage = null;
                    if (countdown != null)
                    {
                        Destroy(countdown.gameObject);
                        countdown = null;
                    }

                    Resources.UnloadUnusedAssets();
                }

                var gameoverPrefab = Resources.Load("Stages/Gameover");
                if (!gameoverPrefab)
                {
                    stageNumber = 1;
                    gameoverPrefab = Resources.Load("Stages/Stage1");
                }

                currentStage = Instantiate(gameoverPrefab) as GameObject;
                if (currentStage)
                {
                    var baseStage = currentStage.GetComponent<BaseStage>();
                    baseStage.SetData(this);
                }
            }
        ));
    }

    #region スタブ
    public IEnumerator LoadingSample(Action onComplete)
    {
        Debug.Log("Loading...");
        yield return new WaitForSeconds(0.5f);

        Debug.Log("Finish!");
        onComplete();
    }
    #endregion
}