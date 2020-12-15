//此本為開頭畫面控制器
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    #region 欄位
    //要using UnityEngine.UI;
    public Button Start_Game;
    public Button Exit_Game;


    #endregion

    #region 事件
    private void Start()
    {
        //給(方法)一個觀察者偵測點擊事件
        Start_Game.onClick.AddListener(GameStart);
        Start_Game.onClick.AddListener(GameExit);
    }


    #endregion

    #region 方法
    /// <summary>
    /// 遊戲開始
    /// </summary>
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// 歷史分數
    /// </summary>
    public void Historical_score()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameExit()
    {
        Application.Quit();
    }

    #endregion
}
