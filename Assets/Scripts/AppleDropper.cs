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
        StartCoroutine(DropApples());
    }

    IEnumerator DropApples()
    {
        spawnPosition.y = 4;
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        while (true)
        {
            spawnPosition.x = Random.Range(-8, 8);
            Instantiate(ApplePrefabs[0], spawnPosition, rotation);
            yield return _waitForSeconds1;
        }
    }
}
