using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine_0817 : MonoBehaviour
{
    /// <summary>
    /// 创建Cube
    /// </summary>
    /// <returns>等待1秒</returns>
    IEnumerator CreateCube ()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = Vector3.one * i;
        }
        yield return new WaitForSeconds (1f);
    }

    /// <summary>
    /// 保存协程，防止start和stop的不是同一个对象
    /// </summary>
    private Coroutine m_Coroutine=null;

    private void OnGUI()
    {
        if (GUILayout.Button("StartCoroutine"))
        {
            if (m_Coroutine!=null)
            {
                StopCoroutine(m_Coroutine);
            }
            m_Coroutine=StartCoroutine(CreateCube());
        }
        if (GUILayout.Button("StopCoroutine"))
        {
            if (m_Coroutine!=null)
            {
                StopCoroutine(m_Coroutine);
            }
        }
    }
}