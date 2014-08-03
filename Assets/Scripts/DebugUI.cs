using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DebugUI : MonoBehaviour
{
	// display flags
	private bool isShowDebug = true;
	public void ShowDebug(bool flag)
	{
		isShowDebug = flag;
	}
	
	public bool isShowButton = false;
	public void SwitchButton()
	{
		isShowButton = !isShowButton;
	}

	private GameStatus gs;

	public Texture2D num0;


	// display objects
	//private Texture2D txTemp = null;
	
	// display settings
//	private Vector2 posScroll = Vector2.zero;
//	private GUIStyle style;
//	private int labelWidth = 80;
//	private int labelHeight = 20;
//	private int imageWidth = 20;
//	private int imageHeight = 20;

	private GUIStyle debugtextcolor = new GUIStyle();
	
	//private UIAnchor
	
//	private Rect rectScrollArea		=	new Rect(10, 10, 320, 320);
//	
	private Rect rectOpenClose		=	new Rect(0, 360, 50 ,50);
//	private Rect rectUserPic		=	new Rect(60, 360, 50, 50);
//	private Rect rectFriendsPic		=	new Rect(120, 360, 50, 50);
//	
//	private Rect rectPublishInstall	=	new Rect(240, 360, 50, 50);
//	
//	private Rect rectLoginLogout	=	new Rect(0, 410, 50, 50);
//	private Rect rectUserInfo		=	new Rect(60, 410, 50, 50);
//	private Rect rectFriendsInfo	=	new Rect(120, 410, 50, 50);
//	private Rect rectSendRequest	=	new Rect(180, 410, 50, 50);
//	private Rect rectFeed			=	new Rect(240, 410, 50, 50);
//	private Rect rectGetToken		=	new Rect(300, 410, 50, 50);

	private void SetupUIPosision()
	{
		
	}
	
	
#region UI Display Component
	
	private void UI_Score()
	{
		debugtextcolor.normal.textColor = Color.black;
		GUI.Label(new Rect(0, 0, 480, 20),
		          string.Format("Time({0}) | Stage({1}) | Score({2}) | Rank({3})",
		              gs.playTime.ToString(),
		              gs.playStage.ToString(),
		              gs.score.ToString(),
		              gs.rank.ToString()),
		          debugtextcolor);
		debugtextcolor.normal.textColor = Color.yellow;
		GUI.Label(new Rect(1, 1, 480, 20),
		          string.Format("Time({0}) | Stage({1}) | Score({2}) | Rank({3})",
		              gs.playTime.ToString(),
		              gs.playStage.ToString(),
		              gs.score.ToString(),
		              gs.rank.ToString()),
		          debugtextcolor);

		//debugtextcolor.normal.background = num0;
		GUI.Label(new Rect(0, 80, 128, 128), num0, debugtextcolor);

	}
	
#endregion
	
	private void OnGUI()
	{
		// debug button switch
		if (!isShowButton)
		{
			return;
		}
		
		// debug display
		if (isShowDebug)
		{
			UI_Score();
		}
		else
		{
			UI_Score();
		}

	}

	private void Start()
	{
		gs = GameStatus.Instance();

		//gs.score = 997;
	}


}
