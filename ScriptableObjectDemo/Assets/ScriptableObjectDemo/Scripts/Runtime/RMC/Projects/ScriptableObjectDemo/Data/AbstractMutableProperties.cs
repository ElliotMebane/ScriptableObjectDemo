using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ScriptableObjectDemo.Scripts.Runtime.RMC.Projects.ScriptableObjectDemo.Data
{
    public abstract class AbstractMutableProperties : MonoBehaviour
    {
        public string Flavor { get { return _flavor; } set { _flavor = value; } }
        
        [SerializeField]
        private string _flavor;
    }
}