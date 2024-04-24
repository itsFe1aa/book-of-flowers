using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] animation;
    public Transform can;
    public float distance;
    public float duration;

    float time;


    // Update is called once per frame
    void Update()
    {
        var d = Vector3.Distance(transform.position, can.transform.position);
        
        if (d < distance)
            time += Time.deltaTime;

        var p = time / duration;

        spriteRenderer.sprite = animation[Mathf.Min((int) (p * animation.Length), animation.Length)];
        Debug.Log(d + " " + p); 
    }
}

