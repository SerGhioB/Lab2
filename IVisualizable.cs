using System;

namespace Segunda_Fase
{
    public interface IVisualizable
    {
         DateTime startToSee(DateTime dateI);
         void stopToSee(DateTime dateI, DateTime dateF);
    }
}