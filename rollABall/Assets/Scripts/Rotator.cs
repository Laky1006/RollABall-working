using System.Numerics;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(15, 30, 45) * Time.deltaTime);
    }
}
