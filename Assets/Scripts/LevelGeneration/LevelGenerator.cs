using GameOn.UnityHelpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoguelikeVR
{
    public class LevelGenerator : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private RoomVariantContainer roomsContainer;

        [SerializeField]
        private int roomsCount;

        #endregion

        #region Properties

        public List<Room> Rooms { get; private set; } = new List<Room>();

        #endregion

        private void Generate()
        {
            
        }
    }
}
