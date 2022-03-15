using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Drawing;


public class PrimitiveType : MonoBehaviour
{

    public Text nameText;
    public Text colorText;
    public Text speedText;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            nameText.text = "Name: " + gameObject.name;
            colorText.text = "Color: Green";
            speedText.text = "Speed: " + speed;

            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
