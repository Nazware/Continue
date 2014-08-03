using UnityEngine;
using System.Collections;
using System;

public class CountdownController : MonoBehaviour
{
    [SerializeField]
    NumberView numberView;

    DateTime target;

	void Update ()
    {
        var remainingTime = target - DateTime.Now;
        numberView.SetData(remainingTime.Seconds);
	}

    public void Initialize(int countSeconds)
    {
        target = DateTime.Now;
        target = target.AddSeconds(countSeconds);
    }
}
