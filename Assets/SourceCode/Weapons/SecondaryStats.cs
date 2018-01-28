using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryStats{
    int m_key = 0;
    float m_potency = 0;

    public int GetKey(){return m_key;}
    public void SetKey(int new_value){m_key = new_value;}

    public float GetPotency(){return m_potency;}
	public void SetPotency(float new_value){m_potency = new_value;}
}