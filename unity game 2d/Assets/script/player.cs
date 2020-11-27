
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

    
    //  摘要不必要但很重要
    /// <summary>
    /// 發弓的功能
    /// </summary>
    /// <param name="count">弓數量</param>
    /// <param name="speed">弓速度</param>
    private void shoot(int count, int speed = 200)
    {
        print("弓箭數量:" + count);
        print("弓箭速度:" + speed);
    }

    //事件 喚醒 在start之前執行一次
    private void Awake()
    {
        //(剛体) 取得 剛体元件< > ();
        //抓到角色身上 剛体元件 存放到 r2d內;
       r2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        //水平浮點數 取得的軸向(ad左右)
       float a= Input.GetAxis("Horizontal");
        print("水平值:" + a);
        //剛体加速度= new 二維向量(id* 速度 ，id. 加速度.y)
        r2d.velocity = new Vector2(a * speed, r2d.velocity.y);
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }
    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    /// <param name="obj">死亡碰到的物件</param>
    private void dead(string obj)
    {

    }
}



