using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    public GameObject panel;

    public void openPanel(){
        if(panel!=null){
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
