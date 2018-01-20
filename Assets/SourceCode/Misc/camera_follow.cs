using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {

	[SerializeField] float camera_speed;
	[SerializeField] float _x, _y, _z = 0;
	GameObject mc;
	RaycastHit _raycast;
	float dist = 1000f;
	int layerMask;


	private void Awake() {
		mc = GameObject.FindGameObjectWithTag("Player");
		layerMask = LayerMask.GetMask("MouseSurface");
	}
	private void FixedUpdate() {
		CameraFollow();
	}

	 void CameraFollow()
    {
        Vector3 direction;

		var rayFromMouse = Camera.main.ScreenPointToRay(Input.mousePosition);


        if(mc != null)
        {
			if(Physics.Raycast(rayFromMouse, out _raycast, dist, layerMask))
			{
            	direction = new Vector3(mc.transform.position.x + _x, mc.transform.position.y + _y, mc.transform.position.z + _z);
            	transform.position = Vector3.Lerp(direction, _raycast.point, Time.deltaTime * camera_speed);
			}
        }
	}
}
