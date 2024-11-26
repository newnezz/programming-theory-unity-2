using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour // Inheritance 
{
    // ENCAPSULATION
    public string Name { get; set; }

    protected virtual void DisplayText() 
    {
        Debug.Log("Base Shape");
    }

    void OnMouseDown()
    {
        DisplayText();
        AddNameToConsole();
    }

    // ABSTRACTION
    void AddNameToConsole()
    {
        switch(gameObject.name)
        {
            case "Cube":
                Debug.Log("You've clicked a cube!");
                break;
            case "Sphere":
                Debug.Log("You've clicked a sphere!");
                break;
            case "Capsule":
                Debug.Log("You've clicked a capsule!");
                break;
            default:
                break;
        }
    }
}
