using UnityEngine;
using System.Collections;
using System;

public class CountdownController : MonoBehaviour
{
    [SerializeField]
    NumberView numberView;
    [SerializeField]
    int countSecond;

    DateTime target;

	void Start ()
    {
        target = DateTime.Now;
        target = target.AddSeconds(countSecond);
	}
	
	void Update ()
    {
        var remainingTime = target - DateTime.Now;
        numberView.SetData(remainingTime.Seconds);
	}
}
