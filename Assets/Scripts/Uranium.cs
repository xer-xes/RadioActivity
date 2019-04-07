using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranium : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Attraction.Instance.Attract(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Thorium"))
        {
            gameObject.SetActive(false);
        }
    }
}
