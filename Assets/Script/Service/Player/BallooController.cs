using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = System.Random;

namespace Script.Service.Player
{
    public class BallooController : MonoBehaviour
    {
        private GameManage _gameManager ;
        public float upSeepd;
        private SpriteRenderer _spriteRenderer;
        
        [FormerlySerializedAs("SpriteList")]
        public List<Sprite> spriteList;
        private void Awake()
        {
            _gameManager = GameObject.Find("GameManage").GetComponent<GameManage>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }


        // Update is called once per frame
        void Update()
        {
            if (transform.position.y > 7)
            {
                RestPosition();
            }
        }

        private void FixedUpdate()
        {
            transform.Translate(0,upSeepd,0);
        }

        private void OnMouseDown()
        {
            _gameManager.OnNotify();
            RestPosition();
        }

        private void RestPosition()
        {
            Random random = new Random();
            float randomX = (float)(random.NextDouble() * (2.5 - -2.5) + -2.5);
            transform.position = new Vector3(randomX, -6);
            
            int index = random.Next(0, spriteList.Count);
            _spriteRenderer.sprite = spriteList[index];
        }
    }
}
