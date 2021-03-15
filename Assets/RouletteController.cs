using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RouletteController : MonoBehaviour
    {
        float rotSpeed = 0;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
            this.rotSpeed = 100.0f;
            }
            if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0;
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.98f;
        }
    }
