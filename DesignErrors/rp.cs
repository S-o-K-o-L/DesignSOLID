namespace DesignTrue
{
    public class rp
    {
        public string nm { get; set; }
        public int rpc { get; set; }
        public double ice { get; set; }
        public int ant { get; set; }

        public rp(string nm, int rpc, double ice, int ant)
        {
            this.nm = nm;
            this.rpc = rpc;
            this.ice = ice;
            this.ant = ant;
        }
    }
}