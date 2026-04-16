using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float JumpSpeed = 5f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direct = new Vector3(h, 0, v).normalized;
        transform.position = transform.position + direct * moveSpeed * Time.deltaTime;
        
    }
}
//