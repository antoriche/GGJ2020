using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGroup : Key
{

    public List<Key> buttons = new List<Key>();
    public List<Key> currents = new List<Key>();

    void Start()
    {

    }

    void OnAction() { }

    void clickOn(Key button)
    {
        currents.Add(button);
        if (shouldClean())
        {
            currents = new List<Key>();
            currents.Add(button);
            return;
        }
        if (currents.Count == buttons.Count)
        {
            this.activated = true;
        }
    }

    private bool shouldClean()
    {
        for (int i = 0; i < currents.Count; i++)
        {
            if (!currents[i].Equals(buttons[i]))
            {
                return true;
            }
        }
        return false;
    }

    void Update()
    {
        foreach (Key button in buttons)
        {
            if (button.activated)
            {
                clickOn(button);
                button.activated = false;
            }
        }
    }
}
