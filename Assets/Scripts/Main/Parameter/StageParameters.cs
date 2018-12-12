using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageParameters : MonoBehaviour
{

    [SerializeField]
    private GameObject m_Plane;  //何も無いステージパーツ
    [SerializeField]
    private GameObject m_Gool;  //ゴール
    [SerializeField]
    private GameObject m_CheckPoint;　　//チェックポイント
    [SerializeField]
    private GameObject m_Obstacl;　　//障害物
    [SerializeField]
    private GameObject m_Warp;　　//ワープソーン
    [SerializeField]
    private GameObject m_Spring;　　//バネ

    //0:プレイヤー初期位置
    //1:普通のステージ
    //2:ゴール
    //3:チェックポイント
    //4:障害物
    //5:ワープ
    //6:バネ
    public int[,] m_Stage1 =
    { { 1, 1, 2, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 3, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 0, 1, 1 }
    };
    public int[,] m_Stage2 =
    { { 1, 1, 1, 2, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 3, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 0, 1, 1, 1 }
    };
    public int[,] m_Stage3 =
    { { 1, 1, 1, 2, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 3, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 0, 1, 1, 1 }
    };

    //指定された配列内の情報をもとにステージオブジェクトを生成
    public void SetStageObject(int stageObjectNumber, int xPosition, int yPosition, Transform rootStage)
    {

        switch (stageObjectNumber)
        {
            case 0:
            case 1:
                Instantiate(m_Plane, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
            case 2:
                Instantiate(m_Gool, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
            case 3:
                Instantiate(m_CheckPoint, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
            case 4:
                Instantiate(m_Obstacl, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
            case 5:
                Instantiate(m_Warp, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
            case 6:
                Instantiate(m_Spring, new Vector3(xPosition, 0, yPosition), Quaternion.identity, rootStage);
                break;
        }
    }
}