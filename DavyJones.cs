
using System;
using mis321_pa2_jmmalcom.Interfaces;
namespace mis321_pa2_jmmalcom
{
    public class DavyJones: Character
    {
        public DavyJones()
        {
            attackBehavior = new CannonFire();
        }
    }
}