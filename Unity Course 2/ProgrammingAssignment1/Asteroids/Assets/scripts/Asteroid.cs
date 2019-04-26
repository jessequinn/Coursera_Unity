using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Asteroid Class
/// Source of Asteroid sprites (https://opengameart.org/content/2d-asteroid-sprite)
/// Documentation for ForceMode (https://docs.unity3d.com/ScriptReference/ForceMode.Impulse.html)
/// </summary>
public class Asteroid : MonoBehaviour
{
    
    #region fields
    
    //Use to switch between Force Modes
    enum ModeSwitching
    {
        Start,
        Impulse,
        Acceleration,
        Force,
        VelocityChange
    };

    private ModeSwitching m_ModeSwitching;

    private Vector2 direction;
    private Rigidbody2D m_Rigidbody2D;
    private CircleCollider2D m_CircleCollider2D;
    private SpriteRenderer m_SpriteRenderer;
    private Sprite[] sprites;

    private const float MinImpulseForce = 3f;
    private const float MaxImpulseForce = 5f;
    private float angle, magnitude;
    private int spriteSelected;
    private string spriteNames = "asteroid";
    
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        // You get the Rigidbody component you attach to the GameObject
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_CircleCollider2D = GetComponent<CircleCollider2D>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>("Sprites/asteroid");

        // This starts at first mode (nothing happening yet)
        m_ModeSwitching = ModeSwitching.Impulse;

        // Initialising floats
        angle = Random.Range(0, 2 * Mathf.PI);
        magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        
        // Initialising the force which is used on GameObject in various ways
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
       
        // Apply impulse force to get game object moving
        if (m_ModeSwitching == ModeSwitching.Impulse) {
            m_Rigidbody2D.AddForce(direction * magnitude, ForceMode2D.Impulse);
        }
        
        // Use System.Random.Next() to generate an integer from 0 to 4
        System.Random rnd = new System.Random();
        spriteSelected = rnd.Next(0, 4);
        m_SpriteRenderer.sprite = sprites[spriteSelected];
        Vector2 spriteHalfSize = m_SpriteRenderer.sprite.bounds.extents;
        m_CircleCollider2D.radius = spriteHalfSize.x > spriteHalfSize.y ? spriteHalfSize.x : spriteHalfSize.y;       
    }
}
