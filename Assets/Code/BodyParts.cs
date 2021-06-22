using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code
{
    public class BodyParts : MonoBehaviour
    {
        [SerializeField] private GameObject[] bodyParts;
        [SerializeField] private float startSpeed;
        [SerializeField] private GameObject parentOwner;
        private Rigidbody2D[] _bodyRigs;
        private GameObject[] _instantiatedParts;

        private void Start()
        {
            _instantiatedParts = new GameObject[bodyParts.Length];
        }

        public void SpawnParts()
        {
            for (int i = 0; i < bodyParts.Length; i++)
            {
                var newPosition = new Vector2(Random.Range(-5,5),Random.Range(-2,2));
                _instantiatedParts[i] = Instantiate(bodyParts[i], newPosition, Quaternion.identity);
                _instantiatedParts[i].transform.parent = parentOwner.transform;
                _instantiatedParts[i].transform.Rotate(Vector3.forward,Random.Range(0,360));
                var velocityDirection = new Vector2(Random.Range(startSpeed/2 * -i,startSpeed * i),Random.Range(startSpeed/2,startSpeed));
                _instantiatedParts[i].GetComponent<Rigidbody2D>().velocity = velocityDirection * Time.deltaTime;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                SpawnParts();
            }
        }
    }
}