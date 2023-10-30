using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class For3DTile : MonoBehaviour
{
    public For3DTileState state { get; private set; }
    public For3DTileCell cell { get; private set; }
    public int number { get; private set; }
    public bool locked { get; set; }

    private Renderer renderer;

    //private TextMeshProUGUI text;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public void SetState(For3DTileState state, int number)
    {
        this.state = state;
        this.number = number;

        renderer.material = state.material;
        Debug.Log(state.material);

        //background.color = state.backgroundColor;
        //text.color = state.textColor;
        //text.text = number.ToString();
        //Debug.Log(background.sprite);
        //Debug.Log(background.color);
    }

    public void Spawn(For3DTileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }

        this.cell = cell;
        this.cell.tile = this;

        transform.position = cell.transform.position;
    }

    public void MoveTo(For3DTileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }

        this.cell = cell;
        this.cell.tile = this;

        StartCoroutine(Animate(cell.transform.position, false));
    }

    public void Merge(For3DTileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }

        this.cell = null;
        cell.tile.locked = true;

        StartCoroutine(Animate(cell.transform.position, true));

    }

    private IEnumerator Animate(Vector3 to, bool merging)
    {
        float elapsed = 0f;
        float duration = 0.1f;

        Vector3 from = transform.position;

        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = to;

        if (merging)
        {
            Destroy(gameObject);
        }
    }

}

