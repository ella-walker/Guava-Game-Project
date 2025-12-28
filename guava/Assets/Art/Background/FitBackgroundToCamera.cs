using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FitBackgroundToCamera : MonoBehaviour
{
    SpriteRenderer sr;
    Camera cam;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }

    void LateUpdate()
    {
        if (sr.sprite == null || cam == null) return;

        float camHeight = cam.orthographicSize * 2f;
        float camWidth = camHeight * cam.aspect;

        float scaleX = camWidth / sr.sprite.bounds.size.x;
        float scaleY = camHeight / sr.sprite.bounds.size.y;

        float scale = Mathf.Max(scaleX, scaleY) * 1.02f; // overscan

        transform.localScale = new Vector3(scale, scale, 1f);
        transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, transform.position.z);
    }
}


