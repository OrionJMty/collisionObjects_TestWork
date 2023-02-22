using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private ScoreController _scoreCounter;
    private Rigidbody object1;
    private Rigidbody object2;

    [SerializeField]private float _elasticPower;

    [field: SerializeField] public Color ColisionColor { get; set; }

    private void ChangeColisionColor(Collision collision, Color ColisionColor)
    {
        Renderer rendererFound;
        if (collision.collider.gameObject.TryGetComponent(out rendererFound))
        {
            foreach (var contactPoint in collision.contacts)
            {
                if (contactPoint.thisCollider.gameObject.TryGetComponent<Renderer>(out rendererFound))
                {
                    rendererFound.material.color= ColisionColor;
                }
            }
        }
    }

    private void ElasticSmallCollide(Collision collision)
    {
        
        GameObject collisionobject1 = collision.gameObject.gameObject;
        gameObject.GetComponent<Rigidbody>().velocity = (gameObject.transform.position - collisionobject1.transform.position) * _elasticPower;
    }

    private void Start()
    {
        _scoreCounter = ScoreController.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_scoreCounter.isCollision == false)
        {
            _scoreCounter.ScoreIncreaseOnOne();
            _scoreCounter.isCollision = true;
        }
        else
        {
            _scoreCounter.isCollision = false;
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {           
        ChangeColisionColor(collision, ColisionColor);
        ElasticSmallCollide(collision);

    }

}
    
