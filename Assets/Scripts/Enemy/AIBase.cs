using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using GameOn.UnityHelpers;
using RoguelikeVR.Weapons;

namespace RoguelikeVR.AI
{
    public class AIBase : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private PhysicsMovementBase movement;

        [SerializeField]
        private WeaponHolder weaponHolder;

        #endregion

        #region Properties
    
        #endregion

        public void MoveTo(Vector3 position)
        {
            movement.MoveTo(position);
        }

        public void LookAt(Transform target)
        {

        }

        public void SetWeapon(Weapon weapon)
        {
            weaponHolder.SetWeapon(weapon);
        }
    }
}
