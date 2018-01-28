using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    int m_id = 0;
    int m_quality = 0;
    float m_damage = 0;
    List<SecondaryStats> m_list_of_secondary_stats;

    void SetId(int new_value){m_id = new_value;}
    void SetQuality(int new_value){m_quality = new_value;}
    void SetDamage(float new_value){m_damage = new_value;}
    void SetSecondary(List<SecondaryStats> new_list){
        m_list_of_secondary_stats = new_list;
    }
}
