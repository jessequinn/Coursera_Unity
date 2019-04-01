using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField] GameObject prefabGreenRock;
    [SerializeField] GameObject prefabMagentaRock;
    [SerializeField] GameObject prefabWhiteRock;

    // spawn control
    Timer spawnTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        GameObject[] rocks = GameObject.FindGameObjectsWithTag("C4Rock");

        // check for time to spawn a new rock
        if (spawnTimer.Finished && rocks.Length < 3)
        {
            SpawnRock();

            // change spawn timer duration and restart
            spawnTimer.Duration = 1;
            spawnTimer.Run();
        }
    }

    /// <summary>
    /// Spawns a new rock at centered window
    /// </summary>
    void SpawnRock()
    {
        // generate centered location and create new rock
        Vector3 location = new Vector3(Screen.width / 2,
            Screen.height / 2,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        // spawn random prefab
        int prefabNumber = Random.Range(0, 3);
        if (prefabNumber == 0)
        {
            GameObject rock = Instantiate<GameObject>(prefabGreenRock, worldLocation, Quaternion.identity);
            rock.tag = "C4Rock";
        }
        else if (prefabNumber == 1)
        {
            GameObject rock = Instantiate<GameObject>(prefabMagentaRock, worldLocation, Quaternion.identity);
            rock.tag = "C4Rock";
        }
        else
        {
            GameObject rock = Instantiate<GameObject>(prefabWhiteRock, worldLocation, Quaternion.identity);
            rock.tag = "C4Rock";
        }
    }
}