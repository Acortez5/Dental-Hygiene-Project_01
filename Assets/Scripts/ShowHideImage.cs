using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHideImage : MonoBehaviour
{
    public Image imageToToggle;

    private Button button;

    private bool isPressed = false;

    public Color pressedColor;
    public Color unpressedColor;

    private void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Set the initial color of the button
        button.image.color = unpressedColor;

        // Add a listener to the button's onClick event
        button.onClick.AddListener(ChangeColor);
    }

    

    void ChangeColor()
    {
        // Toggle the state of the button
        isPressed = !isPressed;

        // Change the color based on the button state
        if (isPressed)
        {
            button.image.color = pressedColor;
        }
        else
        {
            button.image.color = unpressedColor;
        }
    }

    public void ToggleImageVisibility()
    {
        imageToToggle.gameObject.SetActive(!imageToToggle.gameObject.activeSelf);
    }
    
}
