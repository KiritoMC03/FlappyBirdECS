﻿using UnityEngine;

namespace LeoIntegration
{
    public struct OnCollisionEnterEvent
    {
        public GameObject senderGameObject;
        public Collider collider;
        public ContactPoint firstContactPoint;
        public Vector3 relativeVelocity;
    }
}