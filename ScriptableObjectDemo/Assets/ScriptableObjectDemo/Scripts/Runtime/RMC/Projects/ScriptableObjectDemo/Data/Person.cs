/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using RMC.Core.Projects.ScriptableObjectDemo.Assets;
using RMC.Core.Patterns.AssetObserver;
using UnityEngine.Events;
using Assets.ScriptableObjectDemo.Scripts.Runtime.RMC.Projects.ScriptableObjectDemo.Data;

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
        private PersonEvent _onValidated = new PersonEvent();

        //  Properties ------------------------------------------------------------------------------
        public PersonEvent OnValidated   {  get  {  return _onValidated;  } }
        public string Name  {  get  {  return _name;  } set  {  _name = value; Validate();  } }
        public int Age { get { return _age; } set { _age = value; Validate(); } }
        public Genes Genes  {  get  {  return _genes;  } }
        public AbstractMutableProperties MutableProperties { get { return _mutableProperties; } set { _mutableProperties = value; Validate(); } }

        //  This getter seems redundant here, but its in the interface with the purpose, in theory, 
        //      to generalize the AssetObserver Pattern
        public IAsset Asset  {  get  {  return _genes;  }  }

        //  Fields ----------------------------------------------------------------------------------
        [SerializeField] private string _name;
        [SerializeField] private int _age = 1;
        [SerializeField] private Genes _genes;
        [SerializeField] private AbstractMutableProperties _mutableProperties;

        //  Initialization --------------------------------------------------------------------------
        public Person()
        {
            //
        }

        //  Methods ---------------------------------------------------------------------------------
        public void IncreaseAge()
        {
            Age = Age + 1;
        }

        public override string ToString()
        {
            return Name + ", " + _age + ", " + Genes + ", " + MutableProperties.Flavor;
        }

        public void Validate()
        {
            //  Do some data correction...
            //  Ex...
            _age = Mathf.Clamp(_age, 1, 100);

            //  The unity inspector can 'hold' empties, so check.
            if (_genes != null)
            {
                //Remove and Add EVERY time. Yes :)
                _genes.OnValidated.RemoveListener(Asset_OnValidated);
                _genes.OnValidated.AddListener(Asset_OnValidated);
            }

            //  Dispatch that "I or my asset have been validated so go refresh yourself :)"
            OnValidated.Invoke(this);
        }
        //  Event Handlers --------------------------------------------------------------------------
        public void Asset_OnValidated(IAsset iAsset)
        {
            Validate();
        }
	}

    //  Nested Classes  -----------------------------------------------------------------------------
    [System.Serializable]
    public class PersonEvent : UnityEvent<Person> {}
}
