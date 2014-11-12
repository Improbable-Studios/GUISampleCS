using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonPanelHandler : MonoBehaviour {

	public Transform inputField;
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

	public void buttonSubmit () {
		Debug.Log("SubmitPressed");  
		Text txt = inputField.Find("Text").GetComponent<Text>();
		Debug.Log("Submitted " + txt.text);
	}
	
	public void buttonCancel () {
		Debug.Log("CancelPressed");  
	}
	
	public void buttonReset () {
		Debug.Log("ResetPressed");  
	}
}
