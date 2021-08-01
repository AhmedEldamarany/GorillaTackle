using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class intSO : ScriptableObject
{
    public int value;
    [SerializeField] int defaultValue=0;
    private void OnEnable()
    {
        value = defaultValue;
    }

}
