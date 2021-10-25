using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public TrailRenderer trailRenderer;
    public static List<Color> listOfColors;

    Color RandomColor()
    {
        // generate light color
        return new Color(
              Random.Range(0.4f, 1f),
              Random.Range(0.4f, 1f),
              Random.Range(0.4f, 1f)
          );
    }

    private void Start()
    {
        trailRenderer.material.color = RandomColor();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Earth"))
        {
            Destroy(gameObject);
        }
    }
}
