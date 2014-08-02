using UnityEngine;
using System.Collections;

public class GameStatus
{
	public static GameStatus gs;
	
	public static GameStatus Instance()
	{
		if (gs == null)
		{
			gs = new GameStatus();
			gs.Init();
		}
		
		return gs;
	}



	public int playTime;
	public int playTimeHigh;

	public int playStage;
	public int playStageHigh;

	public int score;
	public int scoreHigh;

	public int rank;
	public int rankHigh;





	public void Init()
	{
		Reset();
		ResetHigh();
	}

	public void Reset()
	{
		playTime = 0;
		playStage = 0;
		score = 0;
		rank = 0;
	}

	public void ResetHigh()
	{
		playTimeHigh = 0;
		playStageHigh = 0;
		scoreHigh = 0;
		rankHigh = 0;
	}



}
