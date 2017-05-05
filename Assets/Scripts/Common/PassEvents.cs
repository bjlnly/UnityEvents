using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PassString : UnityEvent<string>{}

[System.Serializable]
public class PassColor : UnityEvent<Color>{}

[System.Serializable]
public class PassColorReturn : UnityEvent<Color , PassHolder>{}