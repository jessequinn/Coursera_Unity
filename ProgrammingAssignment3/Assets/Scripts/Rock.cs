using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock
/// </summary>
public class Rock : MonoBehaviour
{
    // destroy support
    const float RockLifespanSeconds = 10;
    Timer destroyTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get the rock moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

        // create and start timer
        destroyTimer = gameObject.AddComponent<Timer>();
        destroyTimer.Duration = RockLifespanSeconds;
        destroyTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // destroy rock if destroy timer finished
        if (destroyTimer.Finished)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        enabled = true;
        Destroy(gameObject);
    }
}