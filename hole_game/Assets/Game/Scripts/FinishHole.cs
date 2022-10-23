using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;

public class FinishHole : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        RandomHolePos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomHolePos()
    {
        // Random Position of the Finish Hole
        float xHoleSpawnRange = Random.Range(-7.5f, 7.5f);
        float yHoleSpawnRange = Random.Range(-4f, 2.5f);
        
        transform.position = new Vector2(xHoleSpawnRange, yHoleSpawnRange);
    }
}
