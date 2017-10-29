 public class Capacitor  // �����������
    {
        private readonly int c; // ������� /*�����*/
        private readonly int v; // ������������ ���������� /*�����*/

        public Capacitor(int _c, int _v)
        {
            this.c = _c;
            this.v = _v;
        }



        /*public int c { get { return c; } }
		public int v { get { return v; } }*/
        public void put(short x, short y) { }
    }

    public class Resistor // ��������
    {
        private readonly int[] r_list = { 220, 1000, 10000, 100000 };
        private readonly int r; // ������������� /*��*/
        private readonly int p; // �������� /*����*/

        public Resistor(int _r, int _p)
        {
            this.r = r_list[_r];
            this.p = _p;
        }

        public void put(short x, short y) { }
    }

    public class Diode // ���������
    {
        /*
			0 - red
			1 - orange
			2 - yellow
			3 - green
			4 - blue
			5 - purple
		*/
        private readonly string[] colour_list = { "red", "orange", "yellow", "green", "blue", "purple" };
        private readonly int i; // ���� ���� /*�����*/
                                // ??? private readonly int vf; // ���������� /*�����*/
                                // ??? private readonly int iv; // ������� /*�������*/ 
        private readonly string colour; // ����� ���� /*����*/

        public Diode(int _i, int _colour)
        {
            this.i = _i;
            this.colour = colour_list[_colour];
        }

    }

    public class Amperemeter // ���������
    {
        private readonly double a; // ���� ���� /*������*/

        public Amperemeter(double _a)
        {
            this.a = _a;
        }
    }

    public class Voltmeterr
    {
        private readonly double u; //���������� /*�����*/

        public Voltmeterr()
        {
            this.u = u;
        }
    }
}
