
using UnityEngine;

using FullSerializer;

using GameVy.Core;

namespace GameVy.Game.Common
{
    /// <summary>
    /// This class is a utility class that allows other classes to easily access the game configuration and
    /// the lives and coins systems.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public int lastSelectedLevel;

#if SLICE_PUZZLE_ENABLE_IAP
        public IapManager iapManager;
#endif

        /// <summary>
        /// Unity's Awake method.
        /// </summary>
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);

#if SLICE_PUZZLE_ENABLE_IAP
            iapManager = new IapManager();
#endif
        }
    }
}
