using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Public Attributes
    public Transform cubeTransform;
    public float speed = 3;
    //Private Attributes
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        //Mouse Axis Debug
        //Debug.DrawRay(cubeTransform.position, Vector3.right* Input.GetAxis("Mouse X"), Color.blue);
        //Debug.DrawRay(cubeTransform.position, Vector3.forward* Input.GetAxis("Mouse Y"), Color.red);

        //Keyboard Axis Debug
        Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        
        //Button
        if (Input.GetButtonUp("Fire1"))
            print("Fire!!");

        //Mouse Wheel
        //print("Mousewheel: " + Input.GetAxis("Mouse ScrollWheel"));
        //print("Mouse x: " + Input.GetAxis("Mouse X"));
        //print("Mouse y: " + Input.GetAxis("Mouse Y"));

        //Movement By Mouse
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);

        //Movement by keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);

    }
}