using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackerPrefabArray;
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacking in attackerPrefabArray)
        {
            if(isTimeToSpawn(thisAttacking))
            {
                Spawn(thisAttacking);
            }
        }
	}
    void Spawn (GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }
    bool isTimeToSpawn (GameObject attackerGameObject)
    {
        Attacking attacker = attackerGameObject.GetComponent<Attacking>();
        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;
        if (Time.deltaTime > meanSpawnDelay)
        {

        }
        float threshold = spawnsPerSecond * Time.deltaTime/4;
        return (Random.value < threshold);
       
    }
}
