using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    [SerializeField] private Vector3 rotationPerSec;

    public void Update() {
        var rot = transform.rotation;
        var additionalRotation = rotationPerSec * Time.deltaTime;
        rot.eulerAngles = rot.eulerAngles + additionalRotation;
        transform.rotation = rot;
    }
}
