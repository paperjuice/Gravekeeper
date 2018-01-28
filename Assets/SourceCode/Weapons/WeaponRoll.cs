using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponRoll : MonoBehaviour {

	Weapon weapon;

	void Start(){
		roll_weapon_stats(1);
	}

	//TODO: asta tre sa returneze weapon object
	void roll_weapon_stats(int creep_level){
		int id = generate_id();
		int quality = generate_quality();
		float damage = generate_damage(quality, creep_level);
		List<SecondaryStats> list_of_secondary_stats = generate_secondary(quality, creep_level);


		Debug.Log("ID: " + id +
		          " Quality: " + quality +
				  " Damage: " + damage.ToString("N1") +
				  "  Secondary: " );

		foreach (var a in list_of_secondary_stats)
		{
			Debug.Log("  {Id: " + a.GetKey().ToString("N1") + " Potency: " + a.GetPotency().ToString("N1") + " }");
		}
	}

	int generate_id(){

		System.TimeSpan t = (System.DateTime.UtcNow - new System.DateTime(1970, 1, 1));
     	return (int) t.TotalSeconds;
	}

	int generate_quality(){
		int quality_chance = Random.Range(0, 101);
		if(quality_chance <=70)
			return 1;
		else if(quality_chance >70 && quality_chance <=90)
			return 2;
		else if(quality_chance >90 && quality_chance <98)
			return 3;
		else
			return 4;
	}

	//TODO: super debalansat!!!!
	float generate_damage(float quality, float creep_level){
		
		float min_damage_potency = 0.4f + (quality/10);
		float max_damage_potency = 1.0f + (quality/10);

		float power_range = creep_level * 10.0f;

		return Random.Range(min_damage_potency * power_range, max_damage_potency * power_range);
	}

	List<SecondaryStats> generate_secondary(int quality, float creep_level){
		StatsRoll stats_roll = new StatsRoll();
		List<SecondaryStats> list_of_secondary = new List<SecondaryStats>();
		
		for(var i =0; i < quality; i++){
			list_of_secondary.Add(stats_roll.generate_stats_roll(creep_level));
		}

		return list_of_secondary;
	}
}
