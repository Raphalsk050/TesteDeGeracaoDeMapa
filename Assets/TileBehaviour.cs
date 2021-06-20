using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TileBehaviour : MonoBehaviour
{
    private float _timeToChangeColor;
    private SpriteRenderer _spriteRenderer;
    private float _timer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _timer += Time.deltaTime;
        _timeToChangeColor = Random.Range(0, 1.5f);
        if (_timer >= _timeToChangeColor)
        {
            _spriteRenderer.color = Random.ColorHSV();
            _timer = 0;
        }
    }
}
