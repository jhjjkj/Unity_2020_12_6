﻿using UnityEngine;

public class Car : MonoBehaviour
{
    #region 練習欄位
    // 單行註解 : 不會被程式讀取
    // 欄位語法
    // 修飾詞 類型 名稱 (指定 值);

    // 四大類型
    // 整數 int
    // 浮點數 float
    // 字串 string
    // 布林 bool

    // 修飾詞
    // 私人 : 不會顯示 (預設) private
    // 公開 : 會顯示 public

    // 指定符號 =

    // 欄位屬性
    // 語法
    // [屬性名稱("字串或對應的值")]
    // 標題 Header
    // 提示 Tooltip
    // 範圍 Range
    [Header("高度")]
    [Range(1, 10)]
    public int height = 5;
    [Header("重量"), Tooltip("這是汽車的重量,單位是噸。"), Range(2.5f, 10.5f)]
    public float weight = 5.5f;
    [Header("品牌")]
    public string brand = "BMW";
    [Header("是否有天窗")]
    public bool hasWindow = true;

    // 其他類型
    // 顏色 Color
    public Color myColor1;
    public Color yelloe = Color.yellow;
    public Color green = Color.green;
    public Color myColor2 = new Color(0.5f, 0.3f, 0.1f);
    public Color myColor3 = new Color(0, 0.5f, 0.8f, 0.5f);

    // 座標 向量 2 - 4
    public Vector2 v2Zero = Vector2.zero;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2A = new Vector2(9, 10);

    public Vector3 v3A = new Vector3(1, 2, 3);
    public Vector4 v4A = new Vector4(1, 2, 3, 4);

    // 圖片與音效
    public Sprite picture;
    public AudioClip sound;

    // 遊戲物件 與 元件

    // 遊戲物件 : 儲存階層面板內的物件與預置物
    public GameObject objA;
    public GameObject objB;

    //元件 : 屬性面板上可摺疊的元件
    public Transform tra;
    public Camera cam;
    #endregion

    #region 練習方法

    // 欄位語法
    // 修飾詞 類型 名稱 (指定 值);

    // 方法語法
    // 修飾詞 傳回類型 名稱 () { 程式區塊, 陳述式, 演算法 };

    // void 無傳回 : 呼叫此方法後不會傳回任何資料
    // 自訂方法
    // 不會執行,必須要呼叫才會執行
    private void Test()
    {
        // 輸出 方法
        print("哈囉~");
    }

    // 傳回類型 int
    // 必須傳回 整數資料
    private int Ten()
    {
        // 傳回
        return 10;
    }

    private float OnePointFive()
    {
        return 1.5f;
    }

    private string Name()
    {
        return "KID";
    }

    // 維護擴充性
    private void DriveForward()
    {
        print("往前開");
        print("開車音效");
    }
    private void DriveBack()
    {
        print("往後開");
        print("開車音效");
    }
    private void DriveRight()
    {
        print("往右開");
        print("開車音效");
    }
    private void DriveLeft()
    {
        print("往左開");
        print("開車音效");
    }

    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="direction">方向</param>
    /// <param name="sound">音效</param>
    /// <param name="speed">速度</param>
    private void Drive(string direction, string sound, int speed)
    {
        print("開車方向:" + direction);
        print("開車音效:" + sound);
        print("開車速度:" + speed);
    }

    /// <summary>
    /// 開啟雨刷
    /// </summary>
    /// <param name="speed">雨刷速度</param>
    /// 參數預設值 : 選填式參數
    private void OpenBrush(string sound, int count = 2, int speed = 50)
    {
        print("開雨刷");
        print("音效:" + sound);
        print("雨刷的速度: " + speed);
        print("雨刷的數量: " + count);
    }

    #endregion

    // 名稱藍色 : 事件
    // 在特定時間點會執行的方法
    // 開始事件 : 遊戲開始時執行一次 #endregion
    private void Start()
    {
        #region 練習欄位取得與設定
        // 使用欄位
        // 取得 Get
        print("品牌:" + brand);
        print("高度:" + height);
        // 設定 Set
        hasWindow = false;
        weight = 5.5f;
        #endregion

        // 呼叫方法
        // 方法名稱();
        Test();

        // 傳回方法使用方式
        // 1. 直接當作傳回類型資料使用
        print("傳回的整數:" + Ten());
        print("傳回的浮點數:" + OnePointFive());

        // 2. 儲存在區域變數內
        // 區域變數 : 在事件或方法內可使用的欄位
        // 僅限於此括號內可使用
        string myName = Name();
        print(myName);


        // 呼叫時輸入的 引數
        Drive("後面", "噗噗噗", 100);
        Drive("前面", "噗噗噗", 50);
        Drive("左邊", "咻咻咻", 100);

        OpenBrush("刷刷");
        // 指定預設值參數 參數名稱: 值
        OpenBrush("刷刷", speed: 500);
    }
}
