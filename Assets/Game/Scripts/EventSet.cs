using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSet : MonoBehaviour
{
    public static UnityEvent<GameObject> elementSelected = new();
}
