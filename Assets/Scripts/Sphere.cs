using UnityEngine;
using TMPro;

public class Sphere : Shape // Inheritance 
{
    public TMP_Text textInput;

    void Start()
    {
        Name = gameObject.name;
    }
    // Polymorphism
    protected override void DisplayText()
    {
        textInput.text = "Clicked: " + Name;
    }
}
