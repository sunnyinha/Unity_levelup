
using UnityEngine;

public class Movment2D : MonoBehaviour
{
    //private void awake()
    //{
    //    //새로운 위치 = 현재 위치 + (방향 *속도)
    //    transform.position = transform.position + new Vector3(1, 0, 0) * 1;
    //    // == transform.position += vector3.right * 1;
    //}
    //private void Update()
    //{

    //    //Time.deltaTime=> 이전 update 부터 다음 update 까지 걸리는 시간
    //    transform.position = transform.position + new Vector3(1, 0, 0) * 1 * Time.deltaTime;
    //    // == transform.position += vector3.right * 1 * Time.deltaTime;
    //}

    private float moveSpeed = 5.9f;
    private Vector3 moveDirection = Vector3.zero;
    
    private void Update()
    {
        // Negative = left, a : -1
        // Positive = right, d : 1
        float x = Input.GetAxisRaw("Horizontal"); //좌우 이동

        // Negative = down, s : -1
        // positive = up, w = 1
        float y = Input.GetAxisRaw("Vertical"); // 상하 이동

        // 이동 방향 설정
        moveDirection = new Vector3(x, y, 0);
        // 새로운 위치 = 현재 위치 + (방향 * 속도)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}