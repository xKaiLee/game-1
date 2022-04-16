using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private CharacterController controller;
    public int playerIndex;
    
    public float speed = 6f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerIndex == 1) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                controller.Move(direction * speed * Time.deltaTime);
            }
        }
        else
        {
            float horizontal = Input.GetAxisRaw("Horizontal1");
            float vertical = Input.GetAxisRaw("Vertical1");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                controller.Move(direction * speed * Time.deltaTime);
            }
        }
    }
}
