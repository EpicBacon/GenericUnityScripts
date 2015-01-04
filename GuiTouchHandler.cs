using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GuiTouchHandler : MonoBehaviour
{
    void Update () {
				
        // Code for OnMouseDown in the iPhone. Unquote to test.
      
		if (!Application.isEditor)
		{
			RaycastHit hit = new RaycastHit();
	        for (int i = 0; i < Input.touchCount; ++i) {
	            // Construct a ray from the current touch coordinates
	            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
	            if (Physics.Raycast(ray, out hit)) {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                        hit.transform.gameObject.SendMessage("OnMouseDown");
                    else
                        hit.transform.gameObject.SendMessage("OnMouseEnter");
                }
	    	}
		}
	}
}
