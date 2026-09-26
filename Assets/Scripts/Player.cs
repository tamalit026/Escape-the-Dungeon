using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Start()
    {
        
    }

    Vector3 input = Vector3.zero;

    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");

        transform.position += input * Time.deltaTime * speed;
    }
}
