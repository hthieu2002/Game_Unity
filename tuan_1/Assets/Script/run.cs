    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class run : MonoBehaviour
    {
    public float speed = 10f;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Airplane is ready for takeoff!");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0f, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 rotation = new Vector3(0f, horizontalInput, 0f) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
