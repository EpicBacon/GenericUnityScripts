using UnityEngine;
using System.Collections;

public class MobileCamera : MonoBehaviour {

    public float OrthographicSize = 5;
    public float aspect = 1.33333f;

    void Update()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
                -OrthographicSize * aspect, OrthographicSize * aspect,
                -OrthographicSize, OrthographicSize,
                GetComponent<Camera>().nearClipPlane, GetComponent<Camera>().farClipPlane);
    }
}
