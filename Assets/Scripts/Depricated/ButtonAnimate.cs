using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonAnimate : MonoBehaviour {

	public Transform inputObject;
	public Transform helpBubbleSubmit;
	public Transform helpBubbleReset;
	public Transform helpBubbleCancel;

	protected Transform currentButton;

	private float myTimer = 0.0f;
	private bool timerActive = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(myTimer > 0.0f){
			myTimer -= Time.deltaTime;
		}
		
		if(myTimer <= 0.0 && timerActive){
			Debug.Log("Open GUI Now!!!!!");
			timerActive = false;
			
			switch(currentButton.name)
			{
			case "SubmitButton":
				helpBubbleSubmit.gameObject.SetActive(true);
				break;
			case "ResetButton":
				helpBubbleReset.gameObject.SetActive(true);
				break;
			case "CancelButton":
				helpBubbleCancel.gameObject.SetActive(true);
				break;
			}
		}	
	}

	public void activateTimer(Transform cb)
	{
		timerActive = true;
		myTimer = 1.0f;
		currentButton = cb;
	}

	public void resetTimer()
	{
		timerActive = false;
		myTimer = 0.0f;
		currentButton = null;

		helpBubbleSubmit.gameObject.SetActive(false); 
		helpBubbleReset.gameObject.SetActive(false); 
		helpBubbleCancel.gameObject.SetActive(false);  
	}


	public void onButtonDown(Transform btt) 
	{
//		Debug.Log("Button Down" + btt.localPosition);
//		Vector3 lpos = btt.localPosition;
//		lpos.y = -3;
//		btt.localPosition = lpos;
	}
	
	public void onButtonUp(Transform btt) {
//		//Debug.Log("Button Up" + btt.localPosition);
//		Vector3 lpos = btt.localPosition;
//		lpos.y = 0;
//		btt.localPosition = lpos;
	}
	
	public void onButtonEnter(Transform btt) {
//		Debug.Log("ButtonEnter " + btt.name);
//		timerActive = true;
//		myTimer = 1.0f;
//		
//		currentButton = btt;
	}
	
	public void onButtonExit(Transform btt) {
//		Debug.Log("ButtonLeave " + btt.name);
//		timerActive = false;
//		myTimer = 0.0f;
//		
//		currentButton = null;
//		
//		helpBubbleSubmit.gameObject.SetActive(false); 
//		helpBubbleReset.gameObject.SetActive(false); 
//		helpBubbleCancel.gameObject.SetActive(false);  
	}
	
	
	public void buttonSubmit () {
//		
//		Text txt = inputObject.Find("Text").GetComponent<Text>();
//		
//		Debug.Log("Submitted " + txt.text);
		
	}
	
	public void buttonCancel () {
//		Debug.Log("Cancel");  
	}
	
	public void buttonReset () {
//		Debug.Log("Reset");  
	}

}
