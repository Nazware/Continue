using UnityEngine;
using System.Collections;
using System;

public class CountdownController : MonoBehaviour
{    
    [SerializeField]
    NumberView numberView;

    GameController gameController;

    DateTime target;
    bool gameovered = false;

	void Update ()
    {
        var currentTime = DateTime.Now;
        var remainingTime = target - currentTime;
        if (target <= currentTime)
        {
            if (!gameovered)
            {
                gameController.GameOver();
                gameovered = true;
            }
            remainingTime = new TimeSpan();
        }

        numberView.SetData(remainingTime.Seconds);
	}

    public void Initialize(int countSeconds, GameController gameController)
    {
        target = DateTime.Now;
        target = target.AddSeconds(countSeconds);

        this.gameController = gameController;

        gameovered = false;
    }
}
