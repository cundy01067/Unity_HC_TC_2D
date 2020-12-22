//此本為遊戲場景控制器
using UnityEngine;
using UnityEngine.UI;


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

    /// <summary>
    /// 遊戲開始按鈕_欄位(按鈕_UI)
    /// </summary>
    [Header("遊戲開始按鈕")]
    public Button StartGame;

    /// <summary>
    /// 下一個方塊_欄位
    /// </summary>
    [Header("下一個方塊"), Tooltip("方塊編號")]
    public Transform TraNextArea;

    /// <summary>
    /// 下一顆方塊的編號
    /// </summary>
    public int Index_Next;

    /// <summary>
    /// 畫布_欄位
    /// </summary>
    [Header("畫布")]
    public Transform TraCanvas;


    
    #endregion

    #region 事件

    private void Start()
    {


        //按下開始之後呼叫方塊生成方法(Block_generation)
        StartGame.onClick.AddListener(Block_generation);
        //按下開始遊戲呼叫(Start_game)方法
        StartGame.onClick.AddListener(Start_game);

        



    }


    #endregion

    #region 方法
    //判斷開始遊戲是否被按下
    public bool If_Start_OnClick()
    {
        //StartGame.onClick();
        return true;
    }

    /// <summary>
    /// 遊戲開始按鈕_方法
    /// </summary>
    public void Start_game()
    {
        //按下之後隱藏按鈕
        StartGame.gameObject.SetActive(false);
        //把資料存在 tetris 裡面
        GameObject tetris = TraNextArea.GetChild(Index_Next).gameObject;
        //Instantiate(實例化)生成物件 , 放到父物件裡面
        GameObject Current = Instantiate(tetris, TraCanvas);
        //校準初始生成位置  
        Current.GetComponent<RectTransform>().anchoredPosition = new Vector2(50, 450);
    }

    public void Update()
    {

    }
    /// <summary>
    /// 生成下一顆方塊
    /// </summary>
    public void Block_generation()
    {
        
        //給下一顆方塊編號
        Index_Next = Random.Range(0, 12);
        //顯示右邊下一顆方塊
        TraNextArea.GetChild(Index_Next).gameObject.SetActive(true);
        //必定要傳回
        

    }

    /// <summary>
    /// 分數增加
    /// </summary>
    /// <param name="add">要增加的分數</param>
    private void Add_score(int add)
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
