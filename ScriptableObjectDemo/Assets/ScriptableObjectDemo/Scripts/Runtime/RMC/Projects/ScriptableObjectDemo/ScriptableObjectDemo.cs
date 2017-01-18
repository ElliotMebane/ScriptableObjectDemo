/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using UnityEngine.UI;
using RMC.Core.Projects.ScriptableObjectDemo.Data;
using System.Collections.Generic;
using RMC.Core.Projects.ScriptableObjectDemo.Assets;

namespace RMC.Core.Projects.ScriptableObjectDemo
{
	
    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------
   
    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class ScriptableObjectDemo : MonoBehaviour 
	{
  
        //  Events ----------------------------------------------------------------------------------

        //  Properties ------------------------------------------------------------------------------
		
        //  Fields ----------------------------------------------------------------------------------
        [SerializeField] private Text _outputText;
        [SerializeField] private Button _increaseAgeButton;
        [SerializeField] List<Person> _persons;

        //  Initialization --------------------------------------------------------------------------

        //  Unity Methods ---------------------------------------------------------------------------
        protected void Start () 
		{
            _increaseAgeButton.onClick.AddListener(IncreaseAgeButton_OnClicked);
		}

		protected void Update () 
		{
            Refresh();
		}
		
        //  Methods ---------------------------------------------------------------------------------
        protected void Refresh () 
        {
            string text = "Persons\n";
            foreach (Person person in _persons)
            {
                string eyeColorHex = Genes.ColorToHex(person.Genes.EyeColor);
                text += string.Format("   >  <color='#{0}'>{1}</color>\n", eyeColorHex, person.ToString());
            }
            _outputText.text = text;
        }
		
        //  Event Handlers --------------------------------------------------------------------------
        public void IncreaseAgeButton_OnClicked () 
		{
            foreach (Person person in _persons)
            {
                person.IncreaseAge();
            }
		}
	}
}
