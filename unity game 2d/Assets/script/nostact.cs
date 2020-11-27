
using UnityEngine;

public class nostact : MonoBehaviour
{
    public GameObject objA;
    public GameObject objb;
    public Transform tfa;
    private void Start()
    {
        //取得非靜態 類別
        //遊戲物件 a 的標件
        print(objA.tag);
        print(objb.layer);
        print(tfa.localScale);
        //設定非靜態 屬性

        objb.layer = 5;
        tfa.localScale = new Vector3(3, 3, 3);
    }

    private void Update()
    {

        //使用 非靜態 的方法
        //物件 方法 (參數)
        //物件 旋轉 (x,y,z)
        tfa.Rotate(0, 0, 1);
    }
}
