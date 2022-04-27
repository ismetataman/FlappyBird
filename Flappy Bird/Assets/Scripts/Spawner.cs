using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BirdMove BirdMoveScript;
    public GameObject Obstacles;
    public float height;
    public float time;

    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float Time)
    {
        while(!BirdMoveScript.isDead)
        {
            Instantiate(Obstacles, new Vector3(3,Random.Range(-height, height),0),Quaternion.identity); // Quaternion.identity kendi acisinda

            yield return new WaitForSeconds(Time);
        }

        
    }
}
