using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShelterBuild : MonoBehaviour {
    private Button button;  // this
    
    [SerializeField] private GameObject[] disableObjects;


    private void Init() {
        this.button = GetComponent<Button>();

        this.button.onClick.AddListener(() => OnTask(disableObjects));
    }

    private void Awake() {
        Init();
    }

    private void OnTask(GameObject[] disObj) {
        foreach (GameObject obj in disObj) {
            obj.SetActive(false);
        }
    }
}