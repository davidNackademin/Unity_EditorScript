using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(ClickSquare))]
public class SquareScriptEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ClickSquare clickSquare = (ClickSquare)target;



        //clickSquare.points = EditorGUILayout.IntField("Points", clickSquare.points);
        EditorGUILayout.LabelField("Level", clickSquare.Level.ToString());



    }

}
