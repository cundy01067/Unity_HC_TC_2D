using UnityEngine;

public class TetrisManager : MonoBehaviour
{

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

}
