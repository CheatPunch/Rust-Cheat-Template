using UnityEngine;

namespace CheatTemplate
{
    public class Loader
    {
        public static void Load()
        {
            GameObject menuGameObject = new GameObject("menuObj");
            menuGameObject.AddComponent<Menu>();
            Object.DontDestroyOnLoad(menuGameObject);
        }
    }
}