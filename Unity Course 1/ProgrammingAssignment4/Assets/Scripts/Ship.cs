using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ship Class
/// </summary>
public class Ship : MonoBehaviour
{
    #region Constants

    // default thrust force
    private const float ThrustForce = 5;
    // default rotations per second
    private const float RotateDegreesPerSecond = 40;
    // limit the velocity
    private const float MaxSpeed = 5;

    #endregion

    #region Fields

    private Rigidbody2D rb2d;
    Vector2 thrustDirection = new Vector2(1, 0);
    private Vector3 eulerAngle;
    private float radius;

    #endregion


    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        radius = GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        float angleZ;
        float rotationInput = Input.GetAxis("Rotate");
        float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;

        if (rotationInput < 0)
        {
            rotationAmount *= -1;
            transform.Rotate(Vector3.forward, rotationAmount);
            eulerAngle = transform.eulerAngles;
            angleZ = eulerAngle.z * Mathf.Deg2Rad;
            thrustDirection = new Vector2(Mathf.Cos(angleZ), Mathf.Sin(angleZ));
        }
        else if (rotationInput > 0)
        {
            rotationAmount *= 1;
            transform.Rotate(Vector3.forward, rotationAmount);
            eulerAngle = transform.eulerAngles;
            angleZ = eulerAngle.z * Mathf.Deg2Rad + 90;
            thrustDirection = new Vector2(Mathf.Cos(angleZ), Mathf.Sin(angleZ));
        }
        else
        {
            // stop ship from rotating
            transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));
        }
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            rb2d.velocity = new Vector2(
                Mathf.Clamp(rb2d.velocity.x, -MaxSpeed, MaxSpeed),
                Mathf.Clamp(rb2d.velocity.y, -MaxSpeed, MaxSpeed)
            );
            rb2d.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
        }
    }

    void OnBecameInvisible()
    {
        Vector2 position = transform.position;

        if (position.x + radius > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenLeft + radius;
        }
        else if (position.x - radius < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenRight - radius;
        }

        if (position.y + radius > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenBottom + radius;
        }
        else if (position.y + radius < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenTop - radius;
        }

        transform.position = position;
    }

    #endregion
}