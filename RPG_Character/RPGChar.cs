using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Character
{
    internal class RPGChar
    {
        #region Fields
        //Fields
        private CharacterClasses _characterClass;
        private int _charisma;
        private int _maxCharisma = 20;
        private int _dexterity;
        private int _maxDexterity = 20;
        private int _intellegence;
        private int _maxIntellegence = 20;
        private int _luck;
        private int _maxLuck = 20;
        private string _name;
        private int _strength;
        private int _maxStrength = 20;
        private int _wisdom;
        private int _maxWisdom = 20;
        private List<RPGChar> _partyMembers = new List<RPGChar>();
        #endregion Fields



        private Random _rng = new Random();

        #region Properties
        //Properties
        public CharacterClasses ChacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public List<RPGChar> PartyMembers
        {
            get { return _partyMembers; }
            set { _partyMembers = value; }
        }
        public int Charisma { get { return _charisma; } }
        public int Dexterity { get { return _dexterity; } }
        public int Intellegence { get { return _intellegence; } }
        public int Level { get; set; }
        public int Luck { get { return _luck; } }
        public string Name { get; set; }
        public int Strength { get { return _strength; } }
        public int Wisdom { get { return _wisdom; } }
        #endregion Properties

        public RPGChar()
        {
            Roll();
        }

        public void Roll()
        {
            _charisma = _rng.Next(1, _maxCharisma + 1);
            _dexterity = _rng.Next(1, _maxDexterity + 1);
            _intellegence = _rng.Next(1, _maxIntellegence + 1);
            _luck = _rng.Next(1, _maxLuck + 1);
            _strength = _rng.Next(1, _maxStrength + 1);
            _wisdom = _rng.Next(1, _maxWisdom + 1);
        }

        public static int RollDice (int numberOfDice, int numberOfSides)
        {
            Random r = new Random();
            int total = 0;

            for(int i = 0; i < numberOfDice; i++) 
            {
                total += r.Next(1, numberOfSides);
            }

            return total;
        }
    }

    public enum CharacterClasses
    {
        None = 0,
        Cleric,
        Rouge,
        Barbarian,
        Wizard
    }
}
