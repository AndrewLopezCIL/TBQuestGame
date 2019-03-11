using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public abstract class Character
    {
        public enum ActionType{
            Defend, BasicAttack, SkillOne, SkillTwo, SkillThree
        }
        #region fields
        private int _Id;
        private string _name;
        private int _locationId;
        private ActionType _attackType;
        private bool _isAlive;
        #endregion
        #region properties
        public ActionType TypeOfAttack
        {
            get { return _attackType;  }
            set { _attackType = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }
        #endregion
        #region METHODS
        public virtual string returnName()
        {
            return Name;
        }
        public abstract bool Alive();
        #endregion
    }
}
