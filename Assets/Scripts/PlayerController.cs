using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 7;
    float screenHalfWidthWorldUnits = 9.5f;
    float halfPlayerWidth;

    public event System.Action OnPlayerDeath;

    void Start()
    {
        halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidthWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector3.right * velocity * Time.deltaTime);

        float offscreenRight = screenHalfWidthWorldUnits + halfPlayerWidth;
        float offscreenLeft = -screenHalfWidthWorldUnits - halfPlayerWidth;

        if (transform.position.x > offscreenRight)
        {
            transform.position = new Vector2(offscreenLeft, transform.position.y);
        }
        if (transform.position.x < offscreenLeft)
        {
            transform.position = new Vector2(offscreenRight, transform.position.y);
        }

    }

    private void OnTriggerEnter (Collider triggerCollider)
    {
        if (triggerCollider.tag == "Hazard")
        {
            if (OnPlayerDeath != null)
            {
                OnPlayerDeath();
            }
            Destroy(gameObject);
        }
    }
}
