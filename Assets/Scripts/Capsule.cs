using UnityEngine;
using TMPro;

public class Capsule : Shape
{
    public TMP_Text textInput;

    protected override string name = "Capsule";
    protected override string color = "Blue";

    protected override void DisplayText()
    {
        textInput.text = "Clicked: " + name;
    }
}
