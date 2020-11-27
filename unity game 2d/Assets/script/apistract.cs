
using UnityEngine;

public class apistract : MonoBehaviour
{
    private void Start()
    {
        //(取得) 靜態屬性
        //類別名稱.靜態屬性名稱
        //數學的 pi;
        print(Mathf.PI);
        //隨機
        //"字串" + 其他類型(串接);
        print("隨機:"+Random.value);

        //(設定) 靜態屬性
        //類別名稱.靜態屬性名稱=值;

        //時間大小= 值:
        Time.timeScale = 10f;

        //使用靜態 方法
        int a = Mathf.Abs (999);
        print("絕對值後的值:" + a);

        float atk = Random.Range(50.5f,100.5f);
        print("隨機攻擊:" + atk);

        //練習
        print("攝影機:" + Camera.allCamerasCount);

        Cursor.visible = false;
        // 練習 (方法)
  
        float number= Mathf.Floor(1.123456f);
        print("去小數點:" + number);
    }
    private void Update()
    {
        print("按下任意鍵:" + Input.anyKey);

        print("遊戲時間:" + Time.time);

        print("是否按下空白:" + Input.GetKeyDown("space"));
    }




}
