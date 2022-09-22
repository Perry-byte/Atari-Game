using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacstudentMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    // private List<GameObject> itemList;
    private Tweener tweener;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        item.GetComponent<Animation>().Play();
        Move();
        // itemList = new List<GameObject>();
        // itemList.Add(item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        tweener.AddTween(item.gameObject.transform, item.transform.position, new Vector3(-11.95f, 4.71f, 2.21f), 1.5f);

        tweener.AddTween(item.transform, item.transform.position, new Vector3(-11.95f, -1.2f, 2.21f), 1.5f);

        tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, -1.2f, 2.21f), 0.5f);

        tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, 4.71f, 2.21f), 0.5f);
    }
}
