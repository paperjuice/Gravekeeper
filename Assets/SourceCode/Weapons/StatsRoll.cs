using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Stats{
	ATTACK_SPEED = 0,
	LEECH = 1,
	BLEED = 2,
	MAX_HP = 3,
	TOTAL = 4
}

//TODO: balance
public class StatsRoll : SecondaryStats {

	float min_value = 0.0f;
	float max_value = 0.0f;

	int key = 0;
	float potency = 0.0f;

	public SecondaryStats generate_stats_roll(float creep_level){
		Stats stat = Stats.TOTAL;
		SecondaryStats secondary_stats = new SecondaryStats();

		int random_stat = Random.Range(0, (int)stat);

		switch (random_stat)
		{
			case (int)Stats.ATTACK_SPEED:
				key = (int)Stats.ATTACK_SPEED;
				potency = generate_attack_speed(creep_level);
				break;

			case (int)Stats.LEECH:
				key = (int)Stats.LEECH;
				potency = generate_leech(creep_level);
				break;

			case (int)Stats.BLEED:
				key = (int)Stats.BLEED;
				potency = generate_leech(creep_level);
				break;

			case (int)Stats.MAX_HP:
				key = (int)Stats.MAX_HP;
				potency = generate_max_hp(creep_level);
				break;
		}

		secondary_stats.SetKey(key);
		secondary_stats.SetPotency(potency);
		
		return secondary_stats;
	}

	//CHANGE: cand cresc creepi peste 25
	float generate_attack_speed(float creep_level){
		min_value = creep_level/50+0.1f;
		max_value = creep_level/50+0.3f;

		return Random.Range(min_value, max_value);
	}

	float generate_leech(float creep_level){
		min_value = 0.1f + creep_level*0.2f;
		max_value = 1.0f + creep_level*0.2f;

		return Random.Range(min_value, max_value);		
	}

	float generate_bleed(float creep_level){
		min_value = creep_level * 0.1f;
		max_value = creep_level * 0.8f;

		return Random.Range(min_value, max_value);
	}

	float generate_max_hp(float creep_level){
		min_value = creep_level;
		max_value = creep_level * 2.0f;

		return Random.Range(min_value, max_value);
	}
}
