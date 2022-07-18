using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOfPlayer : MonoBehaviour
{
    public Bridge prefabBridge;

    public void AddBridge()
    {
        Instantiate(prefabBridge, transform.parent);
        transform.localPosition = transform.localPosition + new Vector3(0, 0.2f, 0.5f);
    }
}
