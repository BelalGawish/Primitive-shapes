using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrimitiveType : MonoBehaviour
{

    public Text nameText;
    public Text colorText;
    public Text speedText;
    public float speed;
    public Material material;
    private string materialName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        material.color = Color.white;
        ShowInfo();
    }

    void SetColor()
    {
        material.color = Color.green;
    }

    void SetRotationSpeed()
    {
        speed = 50.0f;
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    void ShowInfo()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            string materialName = material.name;
            nameText.text = "Name: " + gameObject.name;
            colorText.text = "Color: " + materialName;
            speedText.text = "Speed: " + speed;

            SetColor();
            SetRotationSpeed();
        }
    }
}
