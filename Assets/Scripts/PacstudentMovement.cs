using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacstudentMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    // private List<GameObject> itemList;
    private Tweener tweener;
    private bool one = false;
    private bool two = false;
    private bool three = false;
    private bool four = false;
    private Vector3 right = new Vector3(-11.95f, 4.71f, 2.21f);
    private Vector3 left = new Vector3(-19.0f, -1.2f, 2.21f);
    private Vector3 up = new Vector3(-19.0f, 4.71f, 2.21f);
    private Vector3 down = new Vector3(-11.95f, -1.2f, 2.21f);

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        // item.GetComponent<Animation>().Play();
        // StartCoroutine(Move1());
        // itemList = new List<GameObject>();
        // itemList.Add(item);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Tweener>().tweenStatus() && one == false)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-11.95f, 4.71f, 2.21f), 1.5f);
            one = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && two == false)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-11.95f, -1.2f, 2.21f), 1.5f);
            two = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && three == false)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, -1.2f, 2.21f), 1.5f);
            three = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && four == false)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, 4.71f, 2.21f), 1.5f);
            one = false;
            two = false;
            three = false;
            four = false;
        }
    }
}
