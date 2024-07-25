using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Spine" && Input.GetMouseButtonDown(0)) {
            
            SfxCtrl.SoundPlay();

            Debug.Log("check2");
            Spine1 ws = other.GetComponent<Spine1>();
            ws.wallCount = 0;
            ws.rotationSpeed += 10;
            GameManager.instance.IncreaseScore();
            
            Destroy(gameObject);
        }
    }
}
