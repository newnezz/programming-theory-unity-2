using UnityEngine;
using TMPro;

public class Capsule : Shape // Inheritance 
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
