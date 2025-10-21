using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    //Public Attributes
    public Transform target;
    //Private Attributes
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        //Mouse Touch
        if (Input.GetMouseButtonUp(0))
            print("Boton izquierdo");
        if (Input.GetMouseButtonUp(1))
            print("Boton derecho");
        if (Input.GetMouseButtonUp(2))
            print("Boton central");

        //Mouse position

        print("Mouse x: " + Input.mousePosition.x + " / Mouse y: " + Input.mousePosition.z);

        target.position = Input.mousePosition;
    }
}
