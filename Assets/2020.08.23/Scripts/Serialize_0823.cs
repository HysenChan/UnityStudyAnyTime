using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class Serialize_0823 : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private string name;
    [SerializeField]
    private GameObject prefab;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Serialize_0823))]
public class ScriptInspector:Editor
{
    public override void OnInspectorGUI()
    {
        //更新最新数据
        serializedObject.Update();
        //获取数据信息
        SerializedProperty property = serializedObject.FindProperty("id");
        //赋值数据
        property.intValue = EditorGUILayout.IntField("主键", property.intValue);
        
        property = serializedObject.FindProperty("name");
        property.stringValue = EditorGUILayout.TextField("姓名", property.stringValue);

        property = serializedObject.FindProperty("prefab");
        property.objectReferenceValue =
            EditorGUILayout.ObjectField("游戏对象", property.objectReferenceValue, typeof(GameObject), true);

        //全部保存数据
        serializedObject.ApplyModifiedProperties();
    }
}
#endif


