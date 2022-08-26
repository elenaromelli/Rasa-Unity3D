using UnityEngine;

public class CollisionStop : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter()
    {
        print("WE HIT AN OBSTACLE");
        rb.isKinematic = true;
    }

    /*void OnCollisionEnter(Collision coll)
    {
        print("WE HIT AN OBSTACLE");
        this.transform.position = coll.transform.position; 
        
        /*if (coll.gameObject.tag.Contains("Int1"))
            {
            coll.gameObject.GetComponent<Movement>().enabled = false;
        }
   

        //coll.gameObject.GetComponent<Movement>().enabled = true;
        //transform.position = Vector3;
    }*/
}


