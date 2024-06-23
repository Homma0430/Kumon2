using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHP = 1;
    private int currentHP;
    public UIManager uiManager;
    public GameObject player;
    void Start()
    {
        // �Q�[���J�n���Ɍ��݂�HP���ő�HP�ɐݒ�
        currentHP = maxHP;
        Debug.Log("Player HP initialized to " + currentHP);
    }

    // HP�����炷���\�b�h
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

    // HP���񕜂��郁�\�b�h
    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

        Debug.Log("Player healed by " + amount + ", current HP is " + currentHP);
    }

    // �v���C���[�����񂾂Ƃ��̏���
    private void Die()
    {
        uiManager.ShowGameOverPanel();
        player.SetActive(false);
    }

    // ���݂�HP���擾���郁�\�b�h
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
