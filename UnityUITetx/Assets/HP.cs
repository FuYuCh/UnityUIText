using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class HP : MonoBehaviour
{
    public Text HPText;  //宣告Text物件

    public float hp;
    public float sp;
    //程式一開就會執行的事件
    void Start()
    {
        DisplayHP();
    }
    void Update()
    {
        
    }
    //-HP的回血方法
    public void Sleep()  
    {
        hp += 10;
        DisplayHP();
    }

    //-HP的攻擊方法
    public void BeAttacked()
    {
        hp -= 10.6f;
        DisplayHP();
    }
    //顯示目前HP
    public void DisplayHP()
    {
        HPText.text = hp.ToString("#");
    }
    
}
