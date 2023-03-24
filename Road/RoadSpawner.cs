using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefab;
    protected GameObject roadSpawnPos;
    protected GameObject roadCurrent;
    protected float distance = 0;
    protected int roadLayerOrder = 0;

    private void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");

        this.roadCurrent = roadPrefab;
        this.roadLayerOrder = (int)this.roadPrefab.transform.position.z;
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, roadCurrent.transform.position);
        if (distance > 40) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadLayerOrder;

        this.roadCurrent = Instantiate(this.roadPrefab, pos, this.roadPrefab.transform.rotation);
    }
}
