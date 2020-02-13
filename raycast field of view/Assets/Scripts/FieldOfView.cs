using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public GameObject[] others;
    [Range(-1, 1)]
    public float FOV = 0.5f;
    public float visionRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Find others
        others = GameObject.FindGameObjectsWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        //Calculates angle from self to each target, and normalizes it. (making it between -1 and 1 max)
        Vector3 a = this.transform.forward;
        a.Normalize();
        foreach (GameObject other in others)
        {
            //If it finds itself in the array, skip.
            if (other == this.gameObject) continue;

            Vector3 b = other.transform.position - this.transform.position;
            b.Normalize();
            float dot = Vector3.Dot(a, b);
            dot = Vector3.Dot(a, b);

            //Shoots a raycast to the target if it is in range, in it's field of View and if it has the tag "Target".
            //If you want you can seperate this line into different 'if' statements.
            RaycastHit hit;
            if (Physics.Raycast(transform.position, b, out hit, visionRange) && dot > FOV && hit.transform.tag == "Target")
            {
                //======Put what you want to happen if a target is in it's field of view here=======================

                //==================================================================================================
                Debug.Log("hit" + other.name);
                Debug.DrawRay(transform.position, b * hit.distance, Color.green, 0.1f);
            } 
        }     
    }
}
