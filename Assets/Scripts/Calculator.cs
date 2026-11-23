public static class Calculator
{
    public static ConstantsSO constants;

    public static float Formula1_Gravity(float m)
    {
        return m * constants.g;
    }

    public static float Formula2_Gravitation(float m1, float m2, float r)
    {
        return constants.G * (m1 * m2) / (r * r);
    }

    public static float Formula3_Newton(float m, float a)
    {
        return m * a;
    }

    public static float Formula4_KineticEnergy(float m, float v)
    {
        return (m * v * v) / 2f;
    }

    public static float Formula5_Momentum(float m, float v)
    {
        return m * v;
    }
}

