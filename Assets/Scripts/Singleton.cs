using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
namespace DefaultNamespace
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;
        public static T Instance => _instance;
        [SerializeField] private bool isDontDestroyOnload;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = (T)this;
            }
            else
            {
                Destroy(gameObject);
            }
            if(isDontDestroyOnload)
            {
                DontDestroyOnLoad(this);
            }

        }
    }
}