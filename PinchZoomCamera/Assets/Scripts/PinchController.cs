using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchController : MonoBehaviour {

    public float orthoZoomSpeed = .1f;
    public float fovZoomSpeed = .1f;

    // Update is called once per frame
    void Update () {
		
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchOnePrevPos - touchZeroPrevPos).magnitude;
            float touchDeltaMag = (touchOne.position - touchZero.position).magnitude;

            float deltaMagnitude = prevTouchDeltaMag - touchDeltaMag;

            if (Camera.main.orthographic)
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize + (deltaMagnitude * orthoZoomSpeed);
                Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize, 0.1f);
            }
            else
            {
                Camera.main.fieldOfView = Camera.main.fieldOfView + (deltaMagnitude * orthoZoomSpeed);
                Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView,0.1f,179.9f);
            }

        }

	}
}
