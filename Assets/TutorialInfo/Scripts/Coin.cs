using UnityEngine;
using System.Collections;

namespace Assets.TutorialInfo.Scripts
{
	public class Coin : MonoBehaviour
	{
        
        private const float _ROTATE_SPEED = 2.1f;
        public int costCoin { get; set; }

        public void SetCoin(int price)
        {
            costCoin = price;
        }
        public int  GetCoin() {
            return costCoin;
        }
        void Update()
        {
            RotationCoin();
        }

        private void RotationCoin()
        {
            gameObject.transform.Rotate(new Vector3(0, 0, _ROTATE_SPEED));
        }
    }

    
}