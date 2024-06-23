using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject playerObject; 
    public Vector3 initialPosition; 

    void Start()
    {
        initialPosition = playerObject.transform.position;
    }

    // リスタートするためのメソッド
    public void Restart()
    {
        playerObject.SetActive(true);
        playerObject.transform.position = initialPosition;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
