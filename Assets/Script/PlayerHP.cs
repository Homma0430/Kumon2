using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 1;
    private int currentHP;
    public UIManager uiManager;
    public GameObject player;
    void Start()
    {
        currentHP = maxHP;
        Debug.Log("Player HP initialized to " + currentHP);
    }

    // HP‚ğŒ¸‚ç‚·
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

    // HP‚ğ‰ñ•œ‚·‚é
    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

        Debug.Log("Player healed by " + amount + ", current HP is " + currentHP);
    }

    // ƒvƒŒƒCƒ„[‚ª€‚ñ‚¾‚Æ‚«
    private void Die()
    {
        uiManager.ShowGameOverPanel();
        player.SetActive(false);
    }

    // Œ»İ‚ÌHP
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
