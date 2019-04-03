using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardController : MonoBehaviour
{
    [SerializeField]
    Vector2 speedMinMax;
    float speed;

    float screenHalfHeight;
    float screenEdgeBottom;

    private void Start()
    {
        screenHalfHeight = Camera.main.orthographicSize;
        screenEdgeBottom = -screenHalfHeight - transform.localScale.y;

        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        //transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.y < screenEdgeBottom)
        {
            Destroy (gameObject);
        }
    }
}
