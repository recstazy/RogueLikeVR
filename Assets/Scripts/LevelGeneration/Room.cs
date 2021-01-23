using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RoguelikeVR
{
    public class Room : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private BoxCollider roomBounds;

        [SerializeField]
        private Exit[] exits;

        #endregion

        #region Properties

        public BoxCollider Bounds => roomBounds;
        public Exit[] Exits => exits;
        public Dictionary<Exit, Tunnel> Tunnels { get; private set; }

        #endregion

        public void RegenerateData()
        {
            RegenerateBounds();
            CacheExits();
        }

        public void SetTunnels(Dictionary<Exit, Tunnel> tunnels)
        {
            Tunnels = tunnels;
        }

        private void RegenerateBounds()
        {
            var bounds = new Bounds();
            var renderers = GetComponentsInChildren<MeshRenderer>();

            foreach (var r in renderers)
            {
                bounds.Encapsulate(r.bounds);
            }

            roomBounds.transform.position = bounds.center;
            roomBounds.size = bounds.size;
        }

        private void CacheExits()
        {
            exits = GetComponentsInChildren<Exit>();
        }
    }
}
