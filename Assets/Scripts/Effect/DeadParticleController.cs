using UnityEngine;
using System.Collections;

//このスクリプトは収束→爆散するスクリプトを管理します.
//Settle_Particle prefubにつけて使います.

public class DeadParticleController : MonoBehaviour {

	//制作者：大塚義弥.
	//ここにボス各種のdead_patricleを入れます.
	public GameObject dead_particle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ParticleDestroyCheck();
	}
	void ParticleDestroyCheck(){//Loop設定がされていないパーティクルが再生を終了していた場合デストロイする.
		if(particleSystem.IsAlive() == false){
			//Instantiate(dead_particle,this.transform.position,Quaternion.identity); // コメント合うと. 0617
			Destroy(gameObject);
		}
	}
}
