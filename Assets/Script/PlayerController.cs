using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Move moveScript; // Player �̓����𐧌䂷�� Move �X�N���v�g�ւ̎Q��
    public Countdown countdown; // �J�E���g�_�E���𐧌䂷�� Countdown �X�N���v�g�ւ̎Q��
    public float startDelay = 3f; // �J�E���g�_�E���̒x������

    void Start()
    {
        // �J�E���g�_�E�����J�n����
        countdown.StartCountdown(startDelay);
    }

    // �J�E���g�_�E�����I��������Ă΂�郁�\�b�h
    public void StartPlayerMovement()
    {
        // Move �X�N���v�g�� StartMovement ���\�b�h���Ăяo���� Player �̓������J�n����
        moveScript.StartMovement();
    }
}
