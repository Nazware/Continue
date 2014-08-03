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

		scaleEffect = 1.0f;
		bScaleUp = true;
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

		goNum100.SetActive(lastscore >= 100);
		goNum010.SetActive(lastscore >= 10);
		//goNum001.SetActive(lastscore >= 0);
	}

	private Vector3 posBase;
	private bool bFadeIn;
	private bool bFadeOut;
	private int pauseCount;

	private void FadeIn()
	{
		posBase.x -= 24;
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
		posBase.y += 36;
		if (posBase.y > 360)
		{
			posBase.y = 120;
			posBase.x = 840;
			bFadeOut = false;
		}
		
		transform.position = posBase;
	}

	private bool CheckScore()
	{
		int score = GameStatus.Instance().score;
		
		if ( (lastscore == score) || (score == 0) )
		{
			return false;
		}
		
		lastscore = score;

		return true;
	}

	private float scaleEffect;
	private bool bScaleUp;

	private void UpdateScale()
	{

		if (bScaleUp)
		{
			scaleEffect += 0.01f;
			if (scaleEffect > 1.1f)
			{
				bScaleUp = false;
			}
		}
		else
		{
			scaleEffect -= 0.01f;
			if (scaleEffect < 0.9f)
			{
				bScaleUp = true;
			}
		}
		
		transform.localScale = new Vector3(scaleEffect, scaleEffect, 1.0f);

		posBase.y = 120;
		posBase.x = 360;

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
			if ( GameStatus.Instance().score >= 999 )
			{
				CheckScore();
				UpdateComboScore();
				UpdateScale();
				return;
			}

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
			if ( CheckScore() )
			{
				posBase.y = 120;
				posBase.x = 840;
				bFadeOut = false;
				bFadeIn = true;
			}
		}

		UpdateComboScore();

	}

}
