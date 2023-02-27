
using UnityEngine;

public class RotatePerMinute : MonoBehaviour
{
    
    private float _RotatePerMinute;
    
    void Update()
    {
        _RotatePerMinute = 360 * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(_RotatePerMinute,Vector3.up);
    }
}
