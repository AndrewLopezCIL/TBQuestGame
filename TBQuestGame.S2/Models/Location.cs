using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
   public class Location
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private bool _accessible;

        public bool Accessible
        {   
            get { return _accessible; }
            set { _accessible = value; }
        }

        private bool _fightRoom;

        public bool BossFightRoom
        {
            get { return _fightRoom; }
            set { _fightRoom = value; }
        }





    }
}
