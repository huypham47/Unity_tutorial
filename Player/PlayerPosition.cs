using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject minionFrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();

        checkMinionDead();
    }

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        int index = this.minions.Count + 1;

        if (this.minions.Count >= 7) return;
        GameObject minion = Instantiate(this.minionFrefab);
        minion.name = "MinionPrefab #" + index;

        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }

    void checkMinionDead()
    {
        GameObject minion;
        for(int i=0; i<this.minions.Count; i++)
        {
            minion = minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
    }

}
