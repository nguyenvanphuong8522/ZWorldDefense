using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeArea : MonoBehaviour
{
    [SerializeField]
    private Solider _solider;

    [SerializeField]
    private LayerMask _targetLayerMask;

    private const float _maxDistance = 100f;

    private void OnMouseDrag()
    {
        UpdateSoliderPosition();
    }
    
    /// <summary>
    /// Hàm này lấy vị trí của chuột trên màn hình và chuyển sang tạo độ worldSpace
    /// </summary>
    /// <returns></returns>
    private Vector3 GetPos()
    {
        Vector3 pos = Vector3.zero;
        Ray ray = CameraManager.Instance.Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _maxDistance, _targetLayerMask))
        {
            pos = hit.point;
        }
        return pos;
    }

    /// <summary>
    /// Hàm này cập nhật vị trí cho solider.
    /// </summary>
    private void UpdateSoliderPosition()
    {
        Vector3 pos = GetPos();
        if (_solider != null)
        {
            _solider.UpdatePosition(pos);
        }
        else
        {
            Debug.LogWarning("Soldier reference is missing.");
        }

    }
}
