using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : PrimitiveType
{
    protected override void SetColor()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }

    protected override void SetRotationSpeed()
    {
        speed = 2500.0f;
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    protected override void OnMouseUp()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
}
