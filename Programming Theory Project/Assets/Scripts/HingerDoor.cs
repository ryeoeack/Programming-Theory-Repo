using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingerDoor : Door
{
    private float spinSpeed = 60.0f;
    public override void Open()
    {
        base.Open();
        if (this.openTimer > 0)
        {
            StartCoroutine("Opener");
        }
        print(this.isOpen);
    }
    private void Start()
    {
        this.openTime = 3.0f;
    }
    private void Update()
    {
        this.openTimer -= Time.deltaTime;
    }
    IEnumerator Opener()
    {
        while (this.openTimer > 0)
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
            this.openTimer -= Time.deltaTime;
            yield return null;
        }
    }

}
