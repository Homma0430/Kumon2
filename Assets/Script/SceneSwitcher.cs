using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName;
    public Button switchButton;

    void Start()
    {
        if (switchButton != null)
        {
            switchButton.onClick.AddListener(OnSwitchButtonClick);
        }
        else
        {
            Debug.LogWarning("Switch Button is not assigned.");
        }
    }

    void OnSwitchButtonClick()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
