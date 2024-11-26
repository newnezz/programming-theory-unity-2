using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    protected abstract void DisplayText();
    protected abstract string name;
    protected abstract string color;

    void OnMouseDown()
    {
        DisplayText();
    }
}
