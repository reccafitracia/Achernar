using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class PolygonButton : MonoBehaviour
{
    public PolygonCollider2D targetCollider;

    private PolygonCollider2D buttonCollider;

    void Start()
    {
        buttonCollider = GetComponent<PolygonCollider2D>();
        if (targetCollider != null)
        {
            SyncColliders();
        }
    }

    void Update()
    {
        if (targetCollider != null)
        {
            SyncColliders();
        }
    }

    void SyncColliders()
    {
        buttonCollider.pathCount = targetCollider.pathCount;
        for (int i = 0; i < buttonCollider.pathCount; i++)
        {
            buttonCollider.SetPath(i, targetCollider.GetPath(i));
        }
    }
}
