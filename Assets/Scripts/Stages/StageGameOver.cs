using UnityEngine;
using System.Collections;

public class StageGameOver : BaseStage
{
    [SerializeField]
	GameObject titlePrefab;

	private GameObject goClone;
	private Vector3 posStart;
	private Vector3 posNow;
	private Vector3 posEnd;
	private bool bStop;
	private EffectGameOver eGameOver;
	private int downSpeed;

	enum EffectGameOver
	{
		start,
		down1,
		up1,
		down2,
		up2,
		down3,
		up3,
		end
	}

	private void UpdateClone()
	{
		switch (eGameOver)
		{
		case EffectGameOver.start:
			eGameOver = EffectGameOver.down1;
			break;
		case EffectGameOver.down1:
			UpdateDown1();
			break;
		case EffectGameOver.up1:
			UpdateUp1();
			break;
		case EffectGameOver.down2:
			break;
		case EffectGameOver.up2:
			break;
		case EffectGameOver.down3:
			break;
		case EffectGameOver.up3:
			break;
		case EffectGameOver.end:
			break;
		}
	}

	private void UpdateDown1()
	{
		posNow.y -= downSpeed;
		if (posNow.y <= posEnd.y)
		{
			posNow.y = posEnd.y;
			bStop = true;
			eGameOver = EffectGameOver.end;
		}
		
		//Debug.Log("Move");
		goClone.transform.position = posNow;
	}

	private void UpdateUp1()
	{
		
	}

	private void UpdateDown2()
	{
		
	}
	
	private void UpdateUp2()
	{
		
	}

	private void UpdateDown3()
	{
		
	}
	
	private void UpdateUp3()
	{
		
	}

	private void Start()
    {
		posStart = new Vector3(0, 400, -2);
		posNow = posStart;
		posEnd = new Vector3(0, 0, -2);

		bStop = false;
		eGameOver = EffectGameOver.start;
		downSpeed = 10;

		goClone = CreateStageObject(titlePrefab, posNow);
	}
	
	private void Update()
    {
		if (!bStop)
		{
			UpdateClone();
		}
	}
}
