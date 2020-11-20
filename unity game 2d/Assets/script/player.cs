
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("移動速度"), Range(0,500)]
    public float speed = 10.5f;

    [Header("跳躍"), Range(0, 1000)]
    public float  jump= 100;

    [Header("地板上"), Tooltip("是否在地板上")]
    public bool ground = false;

    private int score;

    [Header("子彈"), Tooltip("存放子彈")]
    public GameObject bull;

    [Header("生成"), Tooltip("子彈生成")]
    public Transform point;

    [Header("子彈速度"), Range(0, 800)]
    public int speedbull = 800;

    [Header("槍音效")]
    public AudioClip sound;

    [Header("生命數"), Range(0, 3)]
    public int live = 3;

    private AudioSource dus;

    private Rigidbody2D r2d;

    private Animator atr;


}
