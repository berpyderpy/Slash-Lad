using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public Transform Aim;
    public float mouseSensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
         float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * 2f;
         float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 2f;

        transform.position = transform.position + new Vector3(mouseX, 0f, mouseY);
    }
}
