using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class Title : MonoBehaviour
{

	// Use this for initialization
	void Start () {
#if UNITY_EDITOR
		EditorUtility.DisplayDialog("title", "message", "ok");
#endif
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
