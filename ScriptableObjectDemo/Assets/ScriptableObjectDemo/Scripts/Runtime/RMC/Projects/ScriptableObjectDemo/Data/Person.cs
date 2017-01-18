/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using RMC.Core.Projects.ScriptableObjectDemo.Assets;

namespace RMC.Core.Projects.ScriptableObjectDemo.Data
{
	
    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------
    [System.Serializable]

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class Person  
	{
  
        //  Events ----------------------------------------------------------------------------------

        //  Properties ------------------------------------------------------------------------------
        public string Name  {  get  {  return _name;  } set  {  _name = value;  } }
        public int Age  {  get  {  return _age;  } set  {  _age = value;  } }
        public Genes Genes  {  get  {  return _genes;  } set  {  _genes = value;  } }

        //  Fields ----------------------------------------------------------------------------------
        [SerializeField] private string _name;
        [SerializeField] private int _age = 1;
        [SerializeField] private Genes _genes;


        //  Initialization --------------------------------------------------------------------------

        //  Methods ---------------------------------------------------------------------------------
        public void IncreaseAge()
        {
            Age = Age + 1;
        }

        public override string ToString()
        {
            return Name + " " + Age + " " + Genes;
        }


        //  Event Handlers --------------------------------------------------------------------------
	}
}
