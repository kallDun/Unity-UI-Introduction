using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickBehaviourScript : MonoBehaviour
{
    void Start() { }
    void Update() { }
    public void OnClick(string name)
    {
        print($"button {name} was clicked!");
    }
}
