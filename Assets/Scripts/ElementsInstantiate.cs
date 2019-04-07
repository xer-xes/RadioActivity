using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsInstantiate : MonoBehaviour
{
    private static ElementsInstantiate instance = null;

    public static ElementsInstantiate Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("ElementsInstantiate").AddComponent<ElementsInstantiate>();
            }
            return instance;
        }
    }

    public void OnApplicationQuit()
    {
        DestroyInstance();
    }

    public void DestroyInstance()
    {
        print("ElementsInstantiate Instance Destroyed");
        instance = null;
    }
    public GameObject Element;

    private void Start()
    {
        StartCoroutine(Elements());
    }

    public IEnumerator Elements()
    {
        yield return new WaitForSeconds(1f);
        GameObject prefab = Instantiate(Element);
        prefab.transform.position = new Vector3(Random.Range(-8, 8), prefab.transform.position.y, Random.Range(-8, 8));
        StartCoroutine(Elements());
    }
}
