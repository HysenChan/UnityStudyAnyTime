using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
    using  UnityEditor;

#endif
public class SerializedArray_0823 : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private GameObject[] targets;
}

#if UNITY_EDITOR
[CustomEditor(typeof(SerializedArray_0823))]
public class ScriptInpsector:Editor
{
    public override void OnInspectorGUI()
    {
        //更新最新数据
        serializedObject.Update();
        //获取数据信息
        SerializedProperty property = serializedObject.FindProperty("id");
        //赋值数据
        property.intValue = EditorGUILayout.IntField("主键", property.intValue);
        //以默认样式回执数组数据
        EditorGUILayout.PropertyField(serializedObject.FindProperty("targets"), true);
        //全部保存数据
        serializedObject.ApplyModifiedProperties();
    }
}
#endif