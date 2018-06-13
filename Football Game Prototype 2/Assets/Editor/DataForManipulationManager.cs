using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DataForManipulationManager : MonoBehaviour {

	[MenuItem("Asset/Create/ButtonForData")]
	public static void CreateAsset(){
		DataForManipulate gg = ScriptableObject.CreateInstance<DataForManipulate> ();
		AssetDatabase.CreateAsset (gg, "Assets/gg.asset");
		AssetDatabase.SaveAssets ();

		EditorUtility.FocusProjectWindow ();
		Selection.activeObject = gg;
	}

	public static DataForManipulationManager ReadPositionFromAsset(string Name){
		string path = "/";
		object o = Resources.Load(path + Name);
		DataForManipulationManager retrievedPositions = (DataForManipulationManager)o;
		return retrievedPositions;

	}

}
