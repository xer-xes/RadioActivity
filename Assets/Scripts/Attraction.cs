using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public float attractionSpeed = 0.5f;

    private static Attraction instance = null;

    public static Attraction Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new GameObject("Attraction").AddComponent<Attraction>();
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
        print("Attraction Instance Destroyed");
        instance = null;
    }

    public void Attract(GameObject gameObject)
    {
        gameObject.transform.Translate(new Vector3(attractionSpeed * Time.deltaTime, 0));
    }
}
