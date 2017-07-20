using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;




namespace Storage
{

    public static class Storage
    {



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<GenericValues> InventoryList = new List<GenericValues>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<CombatRecord> CombatList = new List<CombatRecord>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private static int Experience = 0;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<SkillType> Skills = new List<SkillType>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<int> ModScores = new List<int>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<int> AbilityMod = new List<int>();





        private static int[] slowPace = { 3000, 7500, 14000, 23000, 35000, 53000, 77000, 115000, 160000, 235000, 330000, 475000, 665000, 955000, 1350000, 1900000, 2700000, 3850000, 5350000 };
        private static int[] mediumPace = { 2000, 5000, 9000, 15000, 23000, 35000, 51000, 75000, 105000, 155000, 220000, 315000, 445000, 635000, 890000, 1300000, 1800000, 2550000, 3600000 };
        private static int[] fastPace = { 1300, 3300, 6000, 10000, 15000, 23000, 34000, 50000, 71000, 105000, 145000, 210000, 295000, 425000, 600000, 850000, 1200000, 1700000, 2400000 };

        public static Pace pace = Pace.Medium;



        public static int experience
        {
            get { return Experience; }
            set
            {
                Experience = value;
                CharacterLevel = SetCharacterLvl();
            }
        }
        private static int characterLevel = 1;
        public static int CharacterLevel
        {
            get { return characterLevel; }
            private set { characterLevel = value; }
        }
        public static int SetCharacterLvl()
        {

            switch (pace)
            {
                case Pace.Slow:
                    for (int i = (slowPace.Length - 1); i > 0; i--)
                    {
                        if (Experience > slowPace[i])
                        {
                            return (i + 2);
                        }
                    }
                    return 1;

                case Pace.Medium:
                    for (int i = (mediumPace.Length - 1); i > 0; i--)
                    {
                        if (Experience > mediumPace[i])
                        {
                            return (i + 2);
                        }
                    }
                    return 1;
                case Pace.Fast:
                    for (int i = (fastPace.Length - 1); i > 0; i--)
                    {
                        if (Experience > fastPace[i])
                        {
                            return (i + 2);
                        }
                    }
                    break;
                default:
                    return 1;

            }
            return 1;
        }

    }

    public enum Pace
    {
        Slow, Medium, Fast
    }
    public enum Mod
    {
        STR, DEX, CON, INT, WIS, CHA
    }
}
