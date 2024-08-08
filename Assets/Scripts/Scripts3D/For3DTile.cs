using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class For3DTile : MonoBehaviour
{
    public For3DTileState state { get; private set; }
    public For3DTileCell cell { get; private set; }
    public int number { get; private set; }
    public bool locked { get; set; }

    public Vector3 pos { get; private set; }

    private new Renderer renderer;

    public string matName;

    public TileIdentifier tileIdentifier;

    //private TextMeshProUGUI text;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        tileIdentifier = GetComponent<TileIdentifier>();
        //Debug.Log("mon materiau est " + renderer.material.name.ToString());
    }

    //private void Start()
    //{
    //    Debug.Log("mon materiau est " + renderer.material.name.ToString());
    //}

    //private void Update()
    //{
    //    Debug.Log("mon materiau est " + renderer.material.name);
    //}

    public void SetState(For3DTileState state, int number)
    {
        this.state = state;
        this.number = number;
        //string matName;
        

        renderer.material = state.material;
        //Debug.Log(state.material);

        matName = state.material.name;

        
        StartCoroutine(CoroutineCheckIdentity());

        //if (matName == "M_2")
        //{
        //    Debug.Log("Tuile = " + matName + " appeared in " + gameObject.transform.position);
        //}

        //background.color = state.backgroundColor;
        //text.color = state.textColor;
        //text.text = number.ToString();
        //Debug.Log(background.sprite);
        //Debug.Log(background.color);
    }

    //public void GetInfos(For3DTileState state, For3DTileCell cell)
    //{
    //    this.state = state;
    //    this.cell = cell;
    //    //this.cell.tile = this;
    //    string matName;

    //    matName = state.material.name;

    //    if (matName == "M_2")
    //    {
    //        Debug.Log("Tuile = " + matName + " appeared in " + cell.transform.position);
    //    }

    //}

    public void Spawn(For3DTileCell cell)
    {
        if (this.cell != null)
        {
            this.cell.tile = null;
        }

        this.cell = cell;
        this.cell.tile = this;

        transform.position = cell.transform.position;

        //Debug.Log("appeared in " + cell.transform.position);
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

        //Debug.Log("Merging at " + cell.transform.position);

        StartCoroutine(Animate(cell.transform.position, true));

    }

    private IEnumerator Animate(Vector3 to, bool merging)
    {
        float elapsed = 0f;
        float duration = 0.2f;

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

    private IEnumerator CoroutineCheckIdentity()
    {
        yield return new WaitForSeconds(0.1f);

        tileIdentifier.CheckIdentity();


        //if (matName == "M_2")
        //{
        //    Debug.Log("Tuile = " + matName + " appeared in " + gameObject.transform.position);
        //}
    }

}

