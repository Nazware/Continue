using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject yesButton;
    [SerializeField]
    GameObject noButton;

	void Start ()
    {
	
	}
	
	void Update ()
    {
        var inputs = getInputPositions();

        if (inputs.Count > 0)
        {
            foreach (var input in inputs)
            {
                Ray ray = Camera.main.ScreenPointToRay(input);
                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    var obj = hit.collider.gameObject;
                    onTouch(input, obj);
                }
            }
        }
	}

    void onTouch(Vector3 touchPos, GameObject touchObject)
    {
        Debug.Log(touchPos + ", " + touchObject.name);
    }

    List<Vector3> getInputPositions()
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
}
