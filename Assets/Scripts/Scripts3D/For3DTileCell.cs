using UnityEngine;

public class For3DTileCell : MonoBehaviour
{
    public Vector2Int coordinates { get; set; }
    public For3DTile tile { get; set; }

    public bool empty => tile == null;
    public bool occupied => tile != null;
}
