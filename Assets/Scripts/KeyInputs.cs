using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    //Public Attributes
    //Private Attributes
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        //Key Down & Up: Enter
        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado enter.");
        if (Input.GetKey(KeyCode.Return))
            print("Se esta pulsando enter.");
        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha soltado enter");

        //Other Key
        if (Input.GetKeyUp(KeyCode.A))
            print("Se ha soltado A");
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            print("Se ha soltado Left");
        if (Input.GetKeyUp(KeyCode.F1))
            print("Se ha soltado F1");
        if (Input.GetKeyUp(KeyCode.Space))
            print("Se ha soltado Space");
        if (Input.GetKeyUp(KeyCode.Escape))
            print("Se ha soltado Escape");
        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt))
            print("Se ha soltado Alt");

        //Combination Key
        if (Input.GetKeyDown(KeyCode.E) && (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))) 
            print("Se han pulsado E y Alt"); 
               


    }
}

        

