using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerDown (PointerEventData data) {
		Debug.Log ("ButtonHandler:OnPointerDown " + name);

		Transform imgTr = transform.GetChild (0);

		Vector3 lpos = imgTr.localPosition;
		lpos.y = -3.0f;
		imgTr.localPosition = lpos;
	}
	
	public void OnPointerUp (PointerEventData data) {
		Debug.Log ("ButtonHandler:OnPointerUp " + name);

		Transform imgTr = transform.GetChild (0);

		Vector3 lpos = imgTr.localPosition;
		lpos.y = 0.0f;
		imgTr.localPosition = lpos;

	}
	
	public void OnPointerEnter (PointerEventData data) {
		Debug.Log ("ButtonHandler:OnPointerEnter " + name);
		ButtonPanelHandler bph = transform.parent.GetComponent<ButtonPanelHandler>();
		bph.activateTimer(transform);
	}
	
	public void OnPointerExit (PointerEventData data) {
		Debug.Log ("ButtonHandler:OnPointerExit " + name);
		ButtonPanelHandler bph = transform.parent.GetComponent<ButtonPanelHandler>();
		bph.resetTimer();
	}
}
