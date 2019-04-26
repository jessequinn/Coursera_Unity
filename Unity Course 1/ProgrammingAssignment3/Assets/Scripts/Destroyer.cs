using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys C4 Rocks
/// </summary>
public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
	
    // timer support
    Timer explodeTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 3;
        explodeTimer.Run();
    }

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // check for timer finished and restart
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();

            // blow up C4 rock
            GameObject rock = GameObject.FindWithTag("C4Rock");
            if (rock != null)
            {
                Instantiate<GameObject>(prefabExplosion,
                    rock.transform.position, Quaternion.identity);
                Destroy(rock);
            }
        }
	}
}
