using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 1;
    private int currentHP;
    public UIManager uiManager;
    public GameObject player;
    void Start()
    {
        // ゲーム開始時に現在のHPを最大HPに設定
        currentHP = maxHP;
        Debug.Log("Player HP initialized to " + currentHP);
    }

    // HPを減らすメソッド
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 0)
        {
            currentHP = 0;
        }

        Debug.Log("Player took " + damage + " damage, current HP is " + currentHP);

        if (currentHP == 0)
        {
            Die();
        }
    }

    // HPを回復するメソッド
    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

        Debug.Log("Player healed by " + amount + ", current HP is " + currentHP);
    }

    // プレイヤーが死んだときの処理
    private void Die()
    {
        uiManager.ShowGameOverPanel();
        player.SetActive(false);
    }

    // 現在のHPを取得するメソッド
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
