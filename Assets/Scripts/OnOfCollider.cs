using UnityEngine;

public class OnOfCollider : MonoBehaviour
{
    private BoxCollider boxCollider;
    private bool isColliderActive = true;
    public float timer = 2f;
    public float repeatRate = 2f;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        // İlgili bileşeni alın
        boxCollider = GetComponent<BoxCollider>();
        meshRenderer = GetComponent<MeshRenderer>();

        // Belirli bir süre sonra ToggleCollider metodu çağrılır
        InvokeRepeating("ToggleCollider", timer, repeatRate);
    }

    private void Update() 
    {
         if (!boxCollider.enabled)
        {
            meshRenderer.enabled = false;
        }
        else
        {
            meshRenderer.enabled = true;
        }
    }
    private void ToggleCollider()
    {
        // Box Collider'ı aç veya kapat
        if (boxCollider != null)
        {
            isColliderActive = !isColliderActive;
            boxCollider.enabled = isColliderActive;
        }
    }
}
