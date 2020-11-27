
using UnityEngine;

public class car : MonoBehaviour
{
    // 可讀性 維護性 
    #region 練習欄位
    // 欄位(field)
    // 語法:
    // 類型名稱:整數，浮點數，字串，布林值
    // 公開 public 私人 frivate

    [Header("汽車的cc數"), Tooltip("cc數")]  // unity中文提示 tooltip 更常提示
    [Range(500, 5000)]   // 可拉式滑桿
    public int cc = 2000;
    public float weight = 1803.5f;   // 小數點必加f
    public string brand = "BMW";     // 中文必加""
    public bool window = true;       // 是為 true 否為false

    // 其他類型: 二維 三維 四維 (屬性面板粗体字 Rigibody2D , collider2D)

    public Color red = Color.red;
    public Color yellow = Color.yellow;
    public Color myColor = new Color(0.4f, 0, 0.5f);   //自定色 要加 new

    //向量 2~4維
    public Vector2 pos0 = Vector2.zero;   // zero 00
    public Vector2 pos1 = Vector2.one;    // one 11
    public Vector2 pos2 = new Vector2(7, 9);

    public Vector3 posv3 = Vector3.one;
    public Vector4 posv4 = Vector4.one;

    public GameObject ogj;    // 白線條跟預制物
    public Transform tf;
    public SpriteRenderer sr;

    #endregion

    // 事件 開始 執行一次
    private void Start()
    {
        // 輸出顯示面板上
        print("哈囉");

        //呼叫方法
        drive(1);
        shoot(1, 200);
        shoot(2);
    }

    // 更新事件 每秒 60次
    // 處理 滑鼠 鍵盤
    private void Update()
    {
        print("我一直在更新");
        drive(0.01f);
    }

    // 方法 語法 修飾詞
    // void 無傳回
    // 方法需要呼叫 才執行
    // 參數語法 類型 () 
    // *有預設值參數 要放最右邊*

    private void drive(float speed)
    {
        print("開車中");
        transform.Translate(speed, 0, 0);
    }

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
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {

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
