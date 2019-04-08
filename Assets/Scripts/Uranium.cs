using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranium : MonoBehaviour
{
    public GameObject gameObject;
    [SerializeField] private GameObject elementBox;
    [SerializeField] private GameObject executioner;
    [SerializeField] private GameObject element;
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
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(elementBox.gameObject);
            Destroy(executioner.gameObject);
            Destroy(element.gameObject);
        }
    }
}
