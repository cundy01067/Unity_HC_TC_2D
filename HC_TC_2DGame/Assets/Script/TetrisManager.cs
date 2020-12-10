//此本為遊戲場景控制器
using UnityEngine;


public class TetrisManager : MonoBehaviour
{
    #region 欄位
    [Header("掉落時間"), Range(0.1F, 3)]
    public float timaFall = 1.5F;
    [Header("目前分數")]
    public int score;
    [Header("最高分數")]
    public int scoreHight;
    [Header("等級")]
    public int Lv;
    [Header("結束畫面")]
    public GameObject objFinal;
    [Header("音效:掉落、移動、消除與結束")]
    public AudioClip SoundFall;
    public AudioClip SoundMove;
    public AudioClip SoundClear;
    public AudioClip SoundLose;
    #endregion

    #region 事件


    #endregion

    #region 方法
    /// <summary>
    /// 方塊生成
    /// </summary>
    private void Block_generation()
    {

    }

    /// <summary>
    /// 添加分數
    /// </summary>
    private void Add_score()
    {

    }
    /// <summary>
    /// 遊戲時間
    /// </summary>
    private void Game_Time()
    {

    }
    /// <summary>
    ///遊戲結束
    /// </summary>
    private void Game_Voer()
    {

    }
    /// <summary>
    /// 重新遊戲
    /// </summary>
    private void Game_Reset()
    {

    }
    /// <summary>
    /// 回到主畫面
    /// </summary>
    private void Game_Go_Home()
    {

    }
    #endregion
}
