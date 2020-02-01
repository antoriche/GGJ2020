using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGroup : Key
{

    public List<Key> buttons = new List<Key>();
    private List<Key> currents = new List<Key>();

    void Start()
    {

    }

    void OnAction() { }

    void clickOn(Key button)
    {
        currents.Add(button);
        for (int i = 0; i < currents.Count; i++)
        {
            if (!currents[i].Equals(buttons[i]))
            {
                currents = new List<Key>();
                return;
            }
        }
        if (currents.Count == buttons.Count)
        {
            this.activated = true;
        }
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
