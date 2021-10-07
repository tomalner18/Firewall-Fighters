using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFF : MonoBehaviour
{
    public float sprintSpeed;
    public float counter;
    private bool moved;
    // Start is called before the first frame update
    void Start()
    {
        moved = false;
        gameObject.SetActive(true);
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (!GameManager.manager.GameOver && moved == false && counter < 3)
        {
            counter += Time.deltaTime;
            transform.localPosition += new Vector3(sprintSpeed * Time.deltaTime, 0, 0);
        }
        if(counter > 3)
        {
            moved = true;
            gameObject.SetActive(false);
        }
    }
}
