using UnityEngine;
using System.Collections;

public class CreateDialogs : MonoBehaviour {

	public Transform InputDialogPrefab;

	// Use this for initialization
	void Start () {
		//Transform tf = Instantiate(InputDialogPrefab) as Transform;
		
		//also works but the file hast to be in resources!
		//var tf : Transform = Instantiate(Resources.Load("InputDialogPFB"));
		// tf.SetParent(transform);
		
		//tf.localScale = Vector3(1,1,1);
		//tf.localPosition = Vector3(0,0,0);
		
		//var rt : RectTransform = tf.GetComponent(RectTransform);
		
		//rt.sizeDelta = new Vector2(600,400);
		
		//Debug.Log("width " + tf.right);  
		//Debug.Log("height " + tf.up);  	
	}

	void Awake() {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
