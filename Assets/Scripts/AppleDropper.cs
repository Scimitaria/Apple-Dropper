using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AppleDropper : MonoBehaviour
{
    private int applesDropped = 0;
    private float frequency = 1;
    private float fracOfJourney;
    private Vector2 target, prevTarget;
    private int chance = 11;
    public GameObject[] ApplePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prevTarget = transform.position;
        target = prevTarget;
        StartCoroutine(DropApples());
    }

    void FixedUpdate()
    {
        fracOfJourney = 1/frequency;
        transform.position = Vector2.MoveTowards(transform.position,target,fracOfJourney);//Vector3.Lerp(prevTarget, target, fracOfJourney);
    }

    IEnumerator DropApples()
    {
        float y = transform.position.y;
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        int selector;
        while (true)
        {
            selector = 0;

            //increase difficulty
            if (applesDropped % 20 == 0 && chance > 3) chance -= 1;
            else if (applesDropped % 10 == 0) frequency += 0.5f;

            if (Random.Range(1, 11) == 1) selector = 1;
            prevTarget = target;
            target = new Vector2(Random.Range(-8, 8), y);
            Instantiate(ApplePrefabs[selector], transform.position, rotation);
            applesDropped += 1;

            yield return new WaitForSeconds(1 / frequency);
        }
    }
}
