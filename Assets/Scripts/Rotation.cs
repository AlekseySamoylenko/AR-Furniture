using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rotation : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private Image Image;
    [SerializeField] private ProgrammManager ProgrammManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(RotationFunction);
    }

    // Update is called once per frame
    void RotationFunction()
    {
        if (ProgrammManagerScript.Rotation)
        {
            ProgrammManagerScript.Rotation = false;

            Image.color = Color.white;
        }
        else
        {
            ProgrammManagerScript.Rotation = true;
            Image.color = Color.green;
        }
    }

}
