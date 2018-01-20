using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mc_behaviour : MC_Stats {

	
	[SerializeField] Rigidbody mc_body;
	[SerializeField] float ms;
	[SerializeField] float rs;
	Vector3 movement;
	RaycastHit	_raycast;
	float dist = 10000.0f;
	int layerMask;


	private void Awake() {
		setMaxMovementSpeed(ms);
		setCurrentMovementSpeed(getMaxMovementSpeed());	

		setMaxRotationSpeed(rs);
		setCurrentRotationSpeed(getMaxRotationSpeed());

		layerMask = LayerMask.GetMask("MouseSurface");
	}


	void FixedUpdate(){
		Movement();
		Rotate();
	}

	void Movement() {

        float _x = Input.GetAxisRaw("Horizontal");
		float _z = Input.GetAxisRaw("Vertical");

        // Set the movement vector based on the axis input.
        movement.Set (_x, 0f, _z);
        
        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * getCurrentMovementSpeed();

        // Move the player to it's current position plus the movement.
        mc_body.AddForce (movement);
	}

	void Rotate(){
		var rayFromMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(rayFromMouse, out _raycast, dist, layerMask))
        {
            Vector3 rotate = _raycast.point - transform.position;
            rotate.y = 0f;
           Quaternion newRotation = Quaternion.LookRotation (rotate * rs);

            // Set the player's rotation to this new rotation.
            mc_body.MoveRotation (newRotation);
		}
	}
}
