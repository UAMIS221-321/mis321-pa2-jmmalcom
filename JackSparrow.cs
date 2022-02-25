using System;
using mis321_pa2_jmmalcom.Interfaces;

namespace mis321_pa2_jmmalcom
{
    public class JackSparrow: Character
    {
        public JackSparrow()
        {
            attackBehavior = new Distract();
        }
    }
}