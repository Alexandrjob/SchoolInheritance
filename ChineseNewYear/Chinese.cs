using System;

namespace ChineseNewYear
{
    sealed class Chinese
    {
        public Immunity Immunity { get; private set; }
        public bool IsDead { get; private set; }

        public Chinese(int percentageOfImmunity = 70, bool isInFected = false, Virus virus = null, bool isDead = false)
        {
            Immunity = new Immunity(percentageOfImmunity, virus, isInFected);
            IsDead = isDead;
        }

        public void KillTheChinese()
        {
            IsDead = true;
        }

        public void DefenseImmunity(int damage, Virus virus)
        {
            Immunity.Defence(damage, this, virus);
            Console.WriteLine(this.ToString(virus));
        }

        public string ToString(Virus virus)
        {
            return string.Format("[ Immunity: {0}%; Damage: {1}; isInfected: {2}; AttackVirusName: {3}; isDead: {4} ]",
                Immunity.PercentageOfImmunity,
                Immunity.NameInfactedVirus?.Damage ?? virus.Damage,
                Immunity.IsInFected, Immunity.NameInfactedVirus?.VirusName ?? virus.VirusName,
                IsDead);
        }
    }
}
