using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solider : MonoBehaviour
{
    /// <summary>
    /// Hàm này cập nhật vị trí của solider
    /// </summary>
    public void UpdatePosition(Vector3 pos)
    {
        pos.y = transform.position.y;
        pos.z += 2;
        transform.position = pos;
    }
}
