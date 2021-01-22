namespace FSD_OOP
{
    public interface IPolygon : IColoredShape
    {
        int NumberOfAngles { get; }
        void TranslateToPoints();
    }
}
