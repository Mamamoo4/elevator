using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace elevatorSystem
{
    public interface IElevatorDirection
    {
        void UpdateDirectionLabel(Label label);
    }    
}
