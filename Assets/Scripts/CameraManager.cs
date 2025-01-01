using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    private Camera _camera;
    public override void Awake()
    {
        base.Awake();
        _camera = GetComponent<Camera>();
    }

    public Camera Camera
    {
        get => _camera;
    }
}
