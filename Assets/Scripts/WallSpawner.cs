using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;

    float timer;
    public float spawnInterval = 1.5f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            GameObject newWall = Instantiate(wallPrefab);
           
        }
    }
}
