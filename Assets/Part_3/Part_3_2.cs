using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_2 : MonoBehaviour
{
    private Transform selfObject;
    private Transform sphereObject;
    private Transform cylinderObject;
    //Attach this Script to Part_3_Cube
    void Start()
    {

        //Using PrintOutNameAndPosition print out the name and position of the Part_3_Cube (1pt)
        selfObject = gameObject.GetComponent<Transform>();
        PrintOutNameAndPosition(selfObject.name, selfObject.position);
        //using GameObject.Find get the transform of Part_3_Sphere and use PrintOutNameAndPosition (1pt)
        sphereObject = GameObject.Find("Part_3_Sphere").GetComponent<Transform>();
        PrintOutNameAndPosition(sphereObject.name, sphereObject.position);
        //Using transform.Find or transform.Get get the Transform of Part_3_Cylinder which is a child of Part_3_Sphere
        //and use PrintOutNameAndPosition (1pt)
        cylinderObject = sphereObject.GetChild(0);
        PrintOutNameAndPosition(cylinderObject.name, cylinderObject.position);

    }

    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
