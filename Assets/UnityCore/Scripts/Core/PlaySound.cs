
using UnityEngine;

namespace GameVy.Core
{
    /// <summary>
    /// Utility class to play a sound via the SoundManager.
    /// </summary>
    public class PlaySound : MonoBehaviour
    {
        /// <summary>
        /// Plays the specified sound.
        /// </summary>
        /// <param name="soundName">The name of the sound to play.</param>
        public void Play(string soundName)
        {
            SoundManager.instance.PlaySound(soundName);
        }

        /// <summary>
        /// Plays the specified sound looped.
        /// </summary>
        /// <param name="soundName">The name of the sound to play.</param>
        public void PlayLooped(string soundName)
        {
            SoundManager.instance.PlaySound(soundName, true);
        }

        /// <summary>
        /// Stops the specified sound.
        /// </summary>
        /// <param name="soundName">The name of the sound to stop.</param>
        public void Stop(string soundName)
        {
            SoundManager.instance.StopSound(soundName);
        }
    }
}
