using UnityEngine;

public class Node : MonoBehaviour
{
    public bool isUsable;

    public GameObject testTyle;

    public Node(bool _isUsable, GameObject _testTyle)
    {
        isUsable = _isUsable;
        testTyle = _testTyle;
    }
}
