
struct Location
{
    private double latitude;
    private double lontitude;
    private Planet planet;

    public Location(double latitude, double lontitude, Planet planet)
        : this()
    {
        this.Latitute = latitude;
        this.Lontitude = lontitude;
        this.Planet = planet;
    }
    public double Lontitude
    {
        get { return this.lontitude; }
        set
        {
            this.lontitude = value;
        }
    }

    public double Latitute
    {
        get { return this.latitude; }
        set
        {
            this.latitude = value;
        }
    }
    public Planet Planet
    {
        get { return this.planet; }
        set
        {
            this.planet = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, {1} - {2}", this.latitude, this.lontitude, this.planet);
    }
}


