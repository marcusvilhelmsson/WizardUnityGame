using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{

    public float scrollSpeed = 1;
    Vector2 startPos;
    // Start is called before the first frame update
    public void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    public void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 12);
        transform.position = startPos + Vector2.right * newPos;
    }
}
