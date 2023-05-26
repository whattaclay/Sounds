﻿using UnityEngine;
using UnityEngine.Events;

public class UnToggle : MonoBehaviour
{
    public UnityEvent<bool> toggled = new();

    public void Turn(bool toggle)
    {
        toggled.Invoke(!toggle);
    }
}