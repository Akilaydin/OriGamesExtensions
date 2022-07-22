using System.Collections.Generic;

using UnityEngine;

namespace LogBreaker.Utils.Extensions
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                var temp = array[i];
                int random = Random.Range(i, array.Count);
                array[i] = array[random];
                array[random] = temp;
            }
        }

        public static T GetRandomElementWithDeletion<T>(this List<T> sourceList)
        {
            var randomElement = sourceList.GetRandomElement();

            sourceList.Remove(randomElement);

            return randomElement;
        }
    }
}