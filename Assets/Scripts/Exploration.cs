using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exploration : MonoBehaviour {
    private Button button;  // this
    
    [SerializeField] private GameObject[] disableObjects;
    [SerializeField] private Item[] collectableItems;


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

        ItemRandomGet(Random.Range(1, 4));
    }

    private void ItemRandomGet(int len) {
        for (int i = 0; i < len; i++) {
            PlayerInfo.instance.ItemAdd(this.collectableItems[Random.Range(0, collectableItems.Length)]);
        }
    }
}
