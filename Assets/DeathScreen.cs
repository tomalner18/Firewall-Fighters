using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour {
    public Text title;
    public Text body;
    public Image Icon;

    // Start is called before the first frame update
    void Start() {
        GameManager.manager.ResetEvent += Reset;
    }

    public void Reset() {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

    }

    public void UpdateDeathScreenText(BadItem badItem) {
        Icon.sprite = Resources.Load<Sprite>("BadIcons/" + badItem.type.ToString());
        body.text = string.Format("{0}: {1}\nPress spacebar to continue...", badItem.Title, badItem.description);
    }
}
