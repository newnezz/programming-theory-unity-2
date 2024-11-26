using UnityEngine;
using TMPro;

public class Cube : Shape
{
    public TMP_Text textInput;

    protected override string name = "Cube";
    protected override string color = "Red";

    protected override void DisplayText()
    {
        textInput.text = "Clicked: " + name;
    }
}
