using UnityEngine;
using UnityEngine.SceneManagement; // 引用 場景管理 API

// C# : 繼承
// 擁有此類別的成員 - 欄位、屬性、方法以及事件
public class SceneControl : MonoBehaviour
{
    [Header("音效來源")]
    public AudioSource aud;
    [Header("按鈕音效")]
    public AudioClip soundClick;

    // 1. 方法要讓按鈕呼叫必須設為公開 public

    #region /// <summary> 開始遊戲
    /// </summary>
    #endregion
    public void StartGame()
    {
        // 音效來源.播放一次(音效, 音量)
        aud.PlayOneShot(soundClick, 2);
        // 延遲呼叫("方法名稱", 延遲秒數)
        Invoke("DelayStartGame", 1.5f);
    }

    #region /// <summary> 返回選單
    /// </summary>
    #endregion
    public void BackToMenu()
    {
        aud.PlayOneShot(soundClick, 2);
        Invoke("DelayBackToMenu", 1.5f);
    }

    #region /// <summary> 離開遊戲
    /// </summary>
    #endregion
    public void QuitGame()
    {
        aud.PlayOneShot(soundClick, 2);
        Invoke("DelayQuitGame", 1.5f);
    }

    #region /// <summary> 延遲開始遊戲
    /// </summary>
    #endregion
    private void DelayStartGame()
    {
        // 2. 必須將場景放在 File > Build Setting...
        // 場景管理器.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲場景");
    }

    #region /// <summary> 延遲返回選單
    /// </summary>
    #endregion
    public void DelayBackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    #region /// <summary> 延遲離開遊戲
    /// </summary>
    #endregion
    public void DelayQuitGame()
    {
        // 應用程式 . 離開()
        Application.Quit();
    }
}
