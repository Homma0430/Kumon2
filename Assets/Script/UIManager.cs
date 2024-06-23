using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject clearPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
        clearPanel.SetActive(false);
    }

    // Game Over パネルを表示する
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    // Clear パネルを表示する
    public void ShowClearPanel()
    {
        clearPanel.SetActive(true);
    }

    // カウントダウンやその他UI操作のためのメソッドを追加する場合はここに記述する
}
