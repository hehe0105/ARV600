using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRataion = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRataion -= mouseY;
        xRataion = Mathf.Clamp(xRataion,-90f,90f);

        transform.localRotation = Quaternion.Euler(xRataion,0f,0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
