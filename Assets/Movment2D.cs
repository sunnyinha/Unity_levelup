
using UnityEngine;

public class Movment2D : MonoBehaviour
{
    //private void awake()
    //{
    //    //���ο� ��ġ = ���� ��ġ + (���� *�ӵ�)
    //    transform.position = transform.position + new Vector3(1, 0, 0) * 1;
    //    // == transform.position += vector3.right * 1;
    //}
    //private void Update()
    //{

    //    //Time.deltaTime=> ���� update ���� ���� update ���� �ɸ��� �ð�
    //    transform.position = transform.position + new Vector3(1, 0, 0) * 1 * Time.deltaTime;
    //    // == transform.position += vector3.right * 1 * Time.deltaTime;
    //}

    private float moveSpeed = 5.9f;
    private Vector3 moveDirection = Vector3.zero;
    
    private void Update()
    {
        // Negative = left, a : -1
        // Positive = right, d : 1
        float x = Input.GetAxisRaw("Horizontal"); //�¿� �̵�

        // Negative = down, s : -1
        // positive = up, w = 1
        float y = Input.GetAxisRaw("Vertical"); // ���� �̵�

        // �̵� ���� ����
        moveDirection = new Vector3(x, y, 0);
        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}