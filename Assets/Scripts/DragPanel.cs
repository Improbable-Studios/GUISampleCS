using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DragPanel : MonoBehaviour, IPointerDownHandler, IDragHandler {
	
	private Vector2 pointerOffset;
	private RectTransform canvasRectTransform;
	private RectTransform panelRectTransform;

	public Camera myCam;
	
	void Awake () {
		Canvas canvas = GetComponentInParent <Canvas>();
		if (canvas != null) {
			canvasRectTransform = canvas.transform as RectTransform;
			panelRectTransform = transform.parent as RectTransform;
		}
	}
	
	public void OnPointerDown (PointerEventData data) {
		panelRectTransform.SetAsLastSibling ();

		//Debug.Log("Pos: " + data.position);
		//Debug.Log("Cam: " + data.pressEventCamera.name);

		RectTransformUtility.ScreenPointToLocalPointInRectangle (panelRectTransform, data.position, data.pressEventCamera, out pointerOffset);

		pointerOffset = Vector2.Scale (pointerOffset, panelRectTransform.localScale);

		//Debug.Log("PointerPos: " + pointerOffset);
		//Debug.Log ("Scale: " + panelRectTransform.localScale);

	}
	
	public void OnDrag (PointerEventData data) {
		if (panelRectTransform == null)
			return;
		
		Vector2 pointerPostion = ClampToWindow (data);

		//Debug.Log("Pos: " + data.position);
	    //Debug.Log("Cam: " + data.pressEventCamera.name);

		Vector2 localPointerPosition;
		if ( RectTransformUtility.ScreenPointToLocalPointInRectangle (canvasRectTransform, pointerPostion, data.pressEventCamera, out localPointerPosition) ) {
			//Debug.Log("PointerPos: " + pointerOffset + " lpp: " + localPointerPosition);
			panelRectTransform.localPosition = localPointerPosition - pointerOffset;
		}
	}
	
	Vector2 ClampToWindow (PointerEventData data) {
		Vector2 rawPointerPosition = data.position;
		
		Vector3[] canvasCorners = new Vector3[4];
		canvasRectTransform.GetWorldCorners (canvasCorners);
		
		float clampedX = Mathf.Clamp (rawPointerPosition.x, canvasCorners[0].x, canvasCorners[2].x);
		float clampedY = Mathf.Clamp (rawPointerPosition.y, canvasCorners[0].y, canvasCorners[2].y);
		
		Vector2 newPointerPosition = new Vector2 (clampedX, clampedY);
		return newPointerPosition;
	}
}