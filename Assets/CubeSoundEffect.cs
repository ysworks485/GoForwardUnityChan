using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    ///////////////////////////////////////////////////////////
    // Lesson7 課題作成（Cubeが接触したら音を出す）
    ///////////////////////////////////////////////////////////

    // 地面またはCube同士で接触した場合の処理
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "UnityChan") {
            GetComponent<AudioSource>().Play();
        }
    }
}
