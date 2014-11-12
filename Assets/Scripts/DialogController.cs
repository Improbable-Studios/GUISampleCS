using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("DialogController called");
		transform.localScale = new Vector3(1,1,1);
		transform.localPosition = new Vector3(0,0,0);
		hide();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void show () {
		gameObject.SetActive(true);
	}
	
	public void hide ()  {
		gameObject.SetActive(false);  
	}
	
	public void setPosition ( Vector2 pos ) {
		transform.localPosition = new Vector3(pos.x,pos.y,0);
	}
	
	public void setDimension (Vector2  dim) {
		RectTransform rt = transform.GetComponent<RectTransform>();  
		rt.sizeDelta = dim;
	}
	
	public void setTitle( string title)
	{
		Text txt = transform.Find("MainPanel/TitleText").gameObject.GetComponent<Text>() as Text;
		
		txt.text = title;
	}
	
	public void setText( string text )
	{
		Text txt = transform.Find("MainPanel/NormalText").gameObject.GetComponent<Text>() as Text;
		txt.text = text;
	}




}
