using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine_0817 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateCube());
    }

    IEnumerator CreateCube()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position=Vector3.one*i;
        }
        yield return new WaitForSeconds(1f);
    }
}
