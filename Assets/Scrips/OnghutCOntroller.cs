using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnghutCOntroller : MonoBehaviour
{
    public float force = 5f; // Lực tác động lên đối tượng
    public float moveDistance = 2f; // Khoảng cách di chuyển ngẫu nhiên
    private bool isGrounded; // Kiểm tra đối tượng đã chạm đất hay chưa
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(DetectShake.uonghet == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !isGrounded) // Kiểm tra nếu đối tượng chạm đất và chưa chạm đất trước đó
        {
            isGrounded = true;
            int randomValue = Random.Range(0, 2) == 0 ? -2 : 2;
            rb.AddForce(new Vector2(randomValue, 2f), ForceMode2D.Impulse); // Thêm lực tác động lên đối tượng
            Invoke("StopForce", 2f);
        }
    }
    void StopForce()
    {
        rb.velocity= Vector3.zero;  
    }
}
