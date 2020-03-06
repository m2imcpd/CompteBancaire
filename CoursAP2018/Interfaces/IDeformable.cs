using CoursAP2018.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Interfaces
{
    public interface IDeformable
    {
        Figure Deformation(int coeffH, int coeffV);
    }
}
