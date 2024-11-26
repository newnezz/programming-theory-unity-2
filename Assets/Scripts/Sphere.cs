using UnityEngine;
using TMPro;

public class Sphere : Shape
{
    public TMP_Text textInput;

    protected override string name = "Sphere";
    protected override string color = "Orange";

    protected override void DisplayText()
    {
        textInput.text = "Clicked: " + name;
    }
}
