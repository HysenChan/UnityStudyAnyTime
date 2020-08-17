using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle_0817 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
}
