using UnityEngine;
using System.Collections;

namespace Assets.TutorialInfo.Scripts
{
	public class Player : MonoBehaviour
	{

        [SerializeField] private int _balance;
        [SerializeField] private Coin _coin;
        private const float speed = 0.05f;
        private void OnTriggerEnter(Collider other)
        {


            if (other.name == "Coin(Clone)" || other.name =="Coin")
            { 
                 Coin coin2;
                coin2=other.GetComponent<Coin>();
            Destroy(other.gameObject);
              _balance += coin2.GetCoin();
            //_balance++;
            // Debug.Log($"+{_coin.costCoin}");
           
            Debug.Log(_balance);
        }
        }

        void Update()
		{

           

            if (Input.GetKey(KeyCode.DownArrow)){
				gameObject.transform.position += new Vector3(0, 0, speed);
			}

            if (Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.position -= new Vector3(0, 0, speed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.position += new Vector3(speed, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.position -= new Vector3(speed, 0, 0);
            }
        }
	}
}