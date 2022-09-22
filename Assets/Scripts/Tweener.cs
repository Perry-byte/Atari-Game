using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    // private List<Tween> activeTweens;

    // Start is called before the first frame update
    void Start()
    {
        // activeTweens = new List<Tween>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (activeTweens != null)
        {
            for (int i = 0; i < activeTweens.Count; i++)
            {
                if (Vector3.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos) > 0.1f)
                {
                    Debug.Log("3");
                    activeTweens[i].Target.position = Vector3.Lerp(activeTweens[i].StartPos, activeTweens[i].EndPos, cubic((Time.time - activeTweens[i].StartTime) / activeTweens[i].Duration));
                }
                else
                {
                    Debug.Log("2");
                    activeTweens[i].Target.position = activeTweens[i].EndPos;
                    activeTweens.Remove(activeTweens[i]);
                }
            }
        } */

        if (activeTween != null)
        {
            if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
            {
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, cubic((Time.time - activeTween.StartTime) / activeTween.Duration));
            }
            else
            {
                Debug.Log("5");
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        /*if (TweenExists(targetObject))
        {
            return false;
        }
        else
        {
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }*/
        if (activeTween == null)
        {
            Debug.Log("1");
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }

    float cubic(float num)
    {
        return num * num * num;
    }

    public bool tweenStatus()
    {
        if (activeTween == null)
        {
            return true;
        } else
        {
            return false;
        }
    }

    /* public bool TweenExists(Transform target)
    {
        foreach (Tween tween in activeTweens)
        {
            if (tween.Target == target)
            {
                return true;
            }
        }
        return false;
    } */
}
