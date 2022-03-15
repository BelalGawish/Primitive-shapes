using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrimitiveType : MonoBehaviour
{

    [SerializeField] protected Text nameText;
    [SerializeField] protected Text colorText;
    [SerializeField] protected Text speedText;
    [SerializeField] protected Material material;
    
    protected float speed;
    private string materialName;


    protected virtual void SetColor()
    {
        material.color = Color.green;
    }

   protected virtual void SetRotationSpeed()
    {
        speed = 500.0f;
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    protected virtual void OnMouseDown()
    {
        string materialName = material.name;
        nameText.text = "Name: " + gameObject.name;
        colorText.text = "Color: " + materialName;
        speedText.text = "Speed: " + speed;

        SetRotationSpeed();
        SetColor();
    }

    protected virtual void OnMouseUp()
    {
        material.color = Color.white;
    }
}
