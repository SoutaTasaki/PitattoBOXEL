using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private StageManager m_StageManager;

	// Use this for initialization
	void Start () {
        m_StageManager = StageManager.Instance;  //StageManagerのインスタンスを取得

        m_StageManager.FormStage(1);
	}
}
