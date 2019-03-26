using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {


    public GameObject platformPrefab;
    public GameObject highPlatformPrefab;

    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = 3f;
    public float maxY = 5f;

	// Use this for initialization
	void Start () {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            spawnPosition.y += Random.Range(minY, maxY);

            if (i % 100 == 0)
            {
                Instantiate(highPlatformPrefab, spawnPosition, Quaternion.identity);  
            }
            else
            {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
        }

	}


}
