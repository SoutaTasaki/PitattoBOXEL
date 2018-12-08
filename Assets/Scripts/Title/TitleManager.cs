using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    // タップを検知
    private void Update()
    {
        //画面がタップされたらシーン遷移
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("LoadScene");
        }
    }

    //1秒後にMenuシーンに遷移
    private IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Menu");
    }
}
