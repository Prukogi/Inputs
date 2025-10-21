using UnityEngine;

public class Movement : MonoBehaviour
{
    //Public Attributes
    public float movementSpeed = 5;
    public float rotationSpeed = 5;
    public float zoomSpeed = 5;
    public Transform cameraTransform;

    //Private Attributes
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        //Player Movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        //Camera Rotation
        //cameraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);

        //Player Rotation
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);


        //Zoom camera
        cameraTransform.LookAt(transform.position);
        cameraTransform.Translate(cameraTransform.forward * Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * zoomSpeed * -1);
    }
}
