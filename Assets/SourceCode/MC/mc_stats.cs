using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Stats : MonoBehaviour
{
	float max_health = 0;
	float current_health = 0;

	float max_movement_speed = 0;
	float current_movement_speed = 0;

	float current_rotation_speed = 0;
	float max_rotation_speed = 0;


	public float getMaxHealth(){
		return max_health;
	}

	public void setMaxHealth(float new_value){
		max_health = new_value;
	}

	public float getCurrentHealth(){
		return current_health;
 	}

	public void setCurrentHealth(float new_value){
		current_health = new_value;
	}

	public float getMaxMovementSpeed(){
		return max_movement_speed;
	}

	public void setMaxMovementSpeed(float new_value){
		max_movement_speed = new_value;
	}

	public float getCurrentMovementSpeed(){
		return current_movement_speed;
	}

	public void setCurrentMovementSpeed(float new_value){
		current_movement_speed = new_value;
	}

	public float getCurrentRotationSpeed(){
		return current_rotation_speed;
	}
	
	public void setCurrentRotationSpeed(float new_value){
		current_rotation_speed = new_value;
	}

	public float getMaxRotationSpeed(){
		return max_rotation_speed;
	}

	public void setMaxRotationSpeed(float new_value){
		max_rotation_speed = new_value;
	}

}

