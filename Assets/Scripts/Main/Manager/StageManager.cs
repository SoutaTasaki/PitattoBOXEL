using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField]
    private StageParameters m_StageParamaters;  //StageParametersを参照

    [SerializeField]
    private Transform m_RootStage;  //rootステージ

    private static StageManager m_Instance = null;  //StageManagerのインスタンス
    public static StageManager Instance
    {

        get { return StageManager.m_Instance; }

    }

    //インスタンスの生成
    void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    //ステージを生成
    public void FormStage(int stageNumber)
    {
        switch (stageNumber)
        {
            case 1:
                CreateStage(m_StageParamaters.m_Stage1);
                break;
            case 2:
                CreateStage(m_StageParamaters.m_Stage2);
                break;
            case 3:
                CreateStage(m_StageParamaters.m_Stage3);
                break;
        }
    }
    private void CreateStage(int[,] stageInformation)
    {
        for (int i = 0; i < stageInformation.GetLength(0); i++)
        {
            for (int j = 0; j < stageInformation.GetLength(1); j++)
            {
                m_StageParamaters.SetStageObject(stageInformation[i, j], i, j, m_RootStage);

            }
        }
    }
}