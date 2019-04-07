using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elements : MonoBehaviour
{
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, Uranium.FindObjectOfType<Uranium>().transform.position, 3 * Time.deltaTime);
        if(transform.position == Uranium.FindObjectOfType<Uranium>().transform.position)
        {
            Attraction.Instance.attractionSpeed += 0.1f;
        }
    }
}
