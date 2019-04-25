namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public interface IWeapon
    {
        uint ElectromagneticDamage { get; }
        uint ExplosiveDamage { get; }
        uint KineticDamage { get; }
        string Name { get; }
        string PictureUrl { get; }
        uint ThermalDamage { get; }
        WeaponType Type { get; }
    }
}