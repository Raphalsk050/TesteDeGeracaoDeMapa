using System;
using UnityEngine;

namespace Code
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed;

        private float m_Horizontal;
        private float m_Vertical;
        private Rigidbody2D m_PlayerRig;
        private Vector2 m_Direction;

        private void Start()
        {
            m_PlayerRig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            m_Horizontal = Input.GetAxisRaw("Horizontal");
            m_Vertical = Input.GetAxisRaw("Vertical");
            m_Direction = new Vector2(m_Horizontal, m_Vertical).normalized;
        }

        private void FixedUpdate()
        {
            m_PlayerRig.velocity = m_Direction * speed;
        }
    }
}
