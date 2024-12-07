using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersEvents : MonoBehaviour
{
    [SerializeField] GameObject[] objectEvents;

    public void Activate(AnimationEvent myEvent)
    {
        string stringParm = myEvent.stringParameter;
        int intParam = myEvent.intParameter;

        if (stringParm == "true")
            objectEvents[intParam].SetActive(true);
        else
            objectEvents[intParam].SetActive(false);

    }
}
