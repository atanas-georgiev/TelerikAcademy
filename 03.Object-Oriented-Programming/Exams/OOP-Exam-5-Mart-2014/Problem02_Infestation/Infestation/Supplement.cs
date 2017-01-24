using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Supplement : ISupplement
    {
        public int powerEffect;
        public int healthEffect;
        public int aggressionEffect;

        public Supplement(int power, int health, int aggression)
        {
            this.powerEffect = power;
            this.healthEffect = health;
            this.aggressionEffect = aggression;
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
        }

        public int AggressionEffect
        {
            get { return this.aggressionEffect; }
        }

        void ISupplement.ReactTo(ISupplement otherSupplement)
        {
            ReactTo1(otherSupplement);
        }

        public virtual void ReactTo1(ISupplement otherSupplement)
        {

        }

        int ISupplement.PowerEffect
        {
            get { return this.powerEffect; }
        }

        int ISupplement.HealthEffect
        {
            get { return this.healthEffect; }
        }

        int ISupplement.AggressionEffect
        {
            get { return this.aggressionEffect; }
        }
    }
}
