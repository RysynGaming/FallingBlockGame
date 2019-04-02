using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardController : MonoBehaviour
{
    [SerializeField]
    float speed = 7;
    float screenHalfHeight;
    float screenEdgeBottom;

    private void Start()
    {
        screenHalfHeight = Camera.main.orthographicSize;
        screenEdgeBottom = -screenHalfHeight - transform.localScale.y;
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
