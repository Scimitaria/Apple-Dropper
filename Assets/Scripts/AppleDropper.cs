using System.Collections;
using UnityEngine;

public class AppleDropper : MonoBehaviour
{
    private Vector2 spawnPosition;
    private static WaitForSeconds _waitForSeconds1 = new WaitForSeconds(1f);
    public GameObject[] ApplePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    IEnumerator DropApples()
    {
        while (true)
        {
            yield return _waitForSeconds1;
        }
    }
}
