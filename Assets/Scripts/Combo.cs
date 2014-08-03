using UnityEngine;
using System.Collections;

public class Combo : MonoBehaviour
{
	//public GameObject goBase;

	public GameObject goNum100;
	public GameObject goNum010;
	public GameObject goNum001;

	public Sprite[] spNum = new Sprite[10];

	private GUITexture[] guitxNumbers;



	private void Start()
	{
		posBase = transform.position;

		bFadeIn = false;
		bFadeOut = false;
		pauseCount = 0;
	}

	private int lastscore;
	private float alphacombo;

	private void UpdateComboScore()
	{
		int score_xoo = (lastscore / 100) % 10;
		int score_oxo = (lastscore / 10) % 10;
		int score_oox = lastscore % 10;
		
		goNum100.GetComponent<SpriteRenderer>().sprite = spNum[score_xoo];
		goNum010.GetComponent<SpriteRenderer>().sprite = spNum[score_oxo];
		goNum001.GetComponent<SpriteRenderer>().sprite = spNum[score_oox];

//		alphacombo = (transform.position.x - 360) / 255.0f;
//		if (alphacombo > 1.0f)
//		{
//			alphacombo = 1.0f;
//		}
//		if (alphacombo < 0.0f)
//		{
//			alphacombo = 0.0f;
//		}
//
//		GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, alphacombo);
		
		goNum100.SetActive( (score_xoo > 0) );
		goNum010.SetActive( (score_oxo > 0) );
		goNum001.SetActive( (score_oox > 0) );
	}

	private Vector3 posBase;
	private bool bFadeIn;
	private bool bFadeOut;
	private int pauseCount;

	private void FadeIn()
	{
		posBase.x -= 16;
		if (posBase.x < 360)
		{
			posBase.x = 360;
			bFadeIn = false;
			bFadeOut = true;
			pauseCount = 60;
		}

		transform.position = posBase;
	}

	private void FadeOut()
	{
		posBase.y += 16;
		if (posBase.y > 360)
		{
			posBase.y = 120;
			posBase.x = 840;
			bFadeOut = false;
		}
		
		transform.position = posBase;
	}

	private void Update()
	{
		if (pauseCount > 0)
		{
			pauseCount -= 1;
			return;
		}
		else
		{
			if (bFadeOut)
			{
				FadeOut();
			}
		}



		if (bFadeIn)
		{
			FadeIn();
		}
		else
		{
			int score = GameStatus.Instance().score;

			if (lastscore == score)
			{
				return;
			}

			lastscore = score;
			
			bFadeIn = true;

		}

		UpdateComboScore();

	}

}
