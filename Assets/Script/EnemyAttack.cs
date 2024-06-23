using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;


    void OnCollisionEnter(Collision collision)
    {

        PlayerHP playerScript = collision.gameObject.GetComponent<PlayerHP>();

        if (playerScript != null)
        {
            // �v���C���[�Ƀ_���[�W��^����
            playerScript.TakeDamage(damage);
        }
    }
}
