using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoLocation : MonoBehaviour
{
    public float speedRation = 1;
    public float echoRatios = 10;
    float echoSpeed = 1;
    bool done = false;
    bool isCurrentlyColliding;

    public void CollisionDetected(Sphere sphere)
    {
        isCurrentlyColliding = true;

        // var cubes = GameObject.FindGameObjectsWithTag("findable");

        // foreach (var cube in cubes)
        // {

        //     Vector3 cubePosition = cube.transform.position;


        //     if (isCurrentlyColliding)
        //     {
        //         print(isCurrentlyColliding);
        //         cube.GetComponent<Renderer>().enabled = !cube.GetComponent<Renderer>().enabled;
        //     }
        // }

    }
    void Start()
    {

        Debug.LogError("Press E to start echo location");
        Debug.LogError("if didn't work add findable TAG to cube objects ");
    }
    void Update()
    {
        echoSpeed = echoSpeed + Time.deltaTime + (speedRation / 100);

        if (isCurrentlyColliding)
        {

            // print("colliedd");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            done = true;
            echoSpeed = 0;
            transform.GetChild(0).localScale = new Vector3(1, 1, 1);
            var position = transform.position;
            var cubes = GameObject.FindGameObjectsWithTag("findable");

            // if (transform.GetChild(0).localScale == new Vector3(1, 1, 1))

            //     transform.GetChild(0).localScale = new Vector3(50, 50, 50);
            // else
            //     transform.GetChild(0).localScale = new Vector3(1, 1, 1);

            foreach (var cube in cubes)
            {

                Vector3 cubePosition = cube.transform.position;


                if (isCurrentlyColliding)
                {
                    print(isCurrentlyColliding);
                    cube.GetComponent<Renderer>().enabled = !cube.GetComponent<Renderer>().enabled;
                }
            }
        }
        if (echoSpeed < echoRatios && done)

        {
            transform.GetChild(0).localScale = new Vector3(echoSpeed, echoSpeed, echoSpeed);
            // print(transform.GetChild(0).GetComponent<Collider>().bounds.size);
        }
        else
        {

            transform.GetChild(0).localScale = new Vector3(1, 1, 1);
            done = false;
        }

    }
}
