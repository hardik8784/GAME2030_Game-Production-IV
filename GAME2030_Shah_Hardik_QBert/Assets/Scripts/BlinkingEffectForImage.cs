using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BlinkingEffectForImage : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color(1, 1, 1, 0);
    }
}
