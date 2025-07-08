using UnityEngine;
using System.Collections.Generic;
using UnityEditor.SceneManagement;

namespace Assets.TutorialInfo.Scripts
{
    public static class GetUniqueCordinate
    {
        static System.Random a = new System.Random();
        static List<int> randomList = new List<int>();
        static int MyNumber = 0;
        public static int NewNumber()
        {
            if (!randomList.Contains(MyNumber))
                randomList.Add(MyNumber);
            return a.Next(-4, 4);
        }
    }

    public static class RandomCost
    {
        static System.Random a = new System.Random();
        public static int GetRandomCost()
        {
            return a.Next(1, 10);
        }
    }



    public class Plane : MonoBehaviour
	{
		[SerializeField]private Coin _coin;

        void Start()
        {
            GenerateCoin(12);
        }
        private void GenerateCoin(int countCoin)
        {

            for (int i = 0; i < countCoin; i++)
            {
                var x = Coin.Instantiate(_coin, transform);

                x.SetCoin(Random.Range(2, 10));

                x.gameObject.transform.localPosition =
                    new Vector3(GetUniqueCordinate.NewNumber(), 0.36f, GetUniqueCordinate.NewNumber());
               // Debug.Log(x.GetCoin());
        }    }
        // Update is called once per frame
        void Update()
		{
            
		}
	}
}