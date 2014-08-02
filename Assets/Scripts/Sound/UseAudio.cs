using UnityEngine;
using System.Collections;

public class UseAudio : MonoBehaviour {

	//制作者：高橋明広.
	//目的:３Dの音を鳴らすためのスクリプト.
	// オブジェクト生成時に鳴らす。　大塚追加　0802.

	private		AudioClip	audio_clip;
	public	 	AudioSource	audio_source;
	public	 	bool		roop_play		=	false;
	public		bool 		oncepPlay 		=	false;
	public		string		data_name;	
	[RangeAttribute(0.0f,1.0f)]
	public		float		volume			=	1.0f;
	
	//データをセットする.
	void Awake(){
		this.audio_clip			=	Resources.Load("Sound/"+data_name) as AudioClip;	//Soundフォルダの中.
		if(audio_source	== null){	//もしaudio_sourceが無いのなら(波形を操作しないのなら).
			this.audio_source	=	this.gameObject.AddComponent<AudioSource>();
		}
	}
	
	// Use this for initialization
	void Start () {
		this.audio_source.clip 		= 	this.audio_clip;
		this.audio_source.volume	=	volume;
		if(roop_play == true){//ループするならループ開始.
			loopPlay();
		}
		if(oncepPlay) sePlay();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void loopPlay(){					//ループ再生する.
		if(!this.audio_source.isPlaying){	//音が鳴っていないなら.
			this.audio_source.loop 	= true;
			this.audio_source.Play();
		}
	}
	
	public void sePlay(){					//seを再生する.
		this.audio_source.Play();
	}

	public void stopPlay(){					//音を止める.
		this.audio_source.Stop();
		roop_play	=	false;
	}
	
	public void	spreadChange(float argSpread){	//音の速さを任意で変更.
		this.audio_source.pitch	=	argSpread;
	}
	
	public	void setInitPlay(string	argNumber){	//初期化関数.
		this.audio_clip				=	Resources.Load("Sound/"+argNumber) as AudioClip;
		this.audio_source.clip 		= 	this.audio_clip;
		this.audio_source.volume	=	volume;
	}
}
