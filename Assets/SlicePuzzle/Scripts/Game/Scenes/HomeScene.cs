using GameVy.Core;
using GameVy.Game.Popups;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameVy.Game.Scenes
{

    public class HomeScene : BaseScene
    {
        // Start is called before the first frame update
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }

        public void OnAlertPressed()
        {
            OpenPopup<AlertPopup>("Popups/Alert");
        }
    }
}
