using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFormsApplication1
{
    public class CharSkills
    {
        decimal brave;
        decimal cheat;
        decimal disguise;
        decimal endur;
        decimal heal;
        decimal know;
        decimal lead;
        decimal steal;

        public decimal Steal
        {
            get { return steal; }
            set { steal = value; }
        }

        public decimal Lead
        {
            get { return lead; }
            set { lead = value; }
        }

        public decimal Know
        {
            get { return know; }
            set { know = value; }
        }

        public decimal Heal
        {
            get { return heal; }
            set { heal = value; }
        }

        public decimal Endur
        {
            get { return endur; }
            set { endur = value; }
        }

        public decimal Disguise
        {
            get { return disguise; }
            set { disguise = value; }
        }

        public decimal Cheat
        {
            get { return cheat; }
            set { cheat = value; }
        }

        public decimal Brave
        {
            get { return brave; }
            set { brave = value; }
        }
        
    }
}
