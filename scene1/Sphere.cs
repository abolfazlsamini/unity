using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    bool collisionFlag;
    // GameObject[] findableObject;
    public List<GameObject> findableObject;
    public double visibilitySeconds = 3;


    void OnTriggerEnter(Collider collision)
    {
        // transform.parent.GetComponent<EchoLocation>().CollisionDetected(this);
        if (collision.gameObject.tag == "findable")

        {
            findableObject.Add(collision.gameObject);
            collisionFlag = true;


        }
    }
    void Update()
    {

        foreach (GameObject findable in findableObject)
        {

            if (collisionFlag == true)
                visibilitySeconds -= Time.deltaTime;

            if (visibilitySeconds <= 0)
            {
                collisionFlag = false;
                findable.GetComponent<Renderer>().enabled = false;
            }
            else
            {
                // visibilitySeconds = 0;
                findable.GetComponent<Renderer>().enabled = true;
            }
        }
    }

}
