using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GamManager : MonoBehaviour
{
    [SerializeField] private GameObject MagnitPoint;
    [SerializeField] public GameObject Contruction1;
    [SerializeField] public GameObject Contruction2;
    [SerializeField] public GameObject _constructionContainer;
    [SerializeField] private Vector3 StartPoint;

    void Awake()
    {
        Instantiate(MagnitPoint, StartPoint, Quaternion.identity);
        var randomNumber = Random.Range(0, 100);
        Instantiate(Contruction1, new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)),
            Quaternion.identity, _constructionContainer.transform);
        Instantiate(Contruction2, new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100)),
            Quaternion.identity, _constructionContainer.transform);
        Contruction1.transform.position = new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
        Contruction2.transform.position = new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
        Contruction1.gameObject.name = ("1");
        Contruction2.gameObject.name = ("2");

    }

}
