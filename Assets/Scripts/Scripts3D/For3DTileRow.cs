using UnityEngine;

public class For3DTileRow : MonoBehaviour
{
    public For3DTileCell[] cells { get; private set; }

    private void Awake()
    {
        cells = GetComponentsInChildren<For3DTileCell>();
    }
}
