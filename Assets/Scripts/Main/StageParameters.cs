﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageParameters : MonoBehaviour {

    //0:プレイヤー初期位置
    //1:普通のステージ
    //2:ゴール
    //3:チェックポイント
    //4:障害物
    //5:ワープ
    //6:バネ
    public static readonly int[,] m_Stage1 =
    { { 1, 1, 2, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 3, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1 },
      { 1, 1, 0, 1, 1 },
    };
    public static readonly int[,] m_Stage2 =
    { { 1, 1, 1, 2, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 3, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 1, 1, 1, 1 },
      { 1, 1, 1, 0, 1, 1, 1 },
    };
    public static readonly int[,] m_Stage3 =
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
      { 1, 1, 1, 0, 1, 1, 1 },
    };
}
