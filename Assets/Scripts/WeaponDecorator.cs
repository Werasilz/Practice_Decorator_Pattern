
public class WeaponDecorator : IWeapon
{
    private readonly IWeapon _unDecoratedWeapon;
    private readonly WeaponAttachment _attachment;

    public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
    {
        _attachment = attachment;
        _unDecoratedWeapon = weapon;
    }

    public float Range
    {
        get { return _unDecoratedWeapon.Range + _attachment.Range; }
    }

    public float Rate
    {
        get { return _unDecoratedWeapon.Rate + _attachment.Rate; }
    }

    public float Strength
    {
        get { return _unDecoratedWeapon.Strength + _attachment.Strength; }
    }

    public float Cooldown
    {
        get { return _unDecoratedWeapon.Cooldown + _attachment.Cooldown; }
    }
}
