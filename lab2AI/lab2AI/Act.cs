using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2AI
{
    public static class Act
    {
        public static double GetActFor(string actType, double x,double t, double g)
        {
            if (actType == "signmoid")
                return Sigmoid(x, g, t);
            if (actType == "treapta")
                return Treapta(x, t);
            if (actType == "semn")
                return Semn(x);
            if (actType == "tanh")
                return TanH(x, g, t);
            if (actType == "rampa")
                return Rampa(x, g);
            return 0;
        }

        public static void ShowControlsFor(string actType, Panel p_gVal, Panel p_tVal)
        {
            p_gVal.Hide();
            p_tVal.Hide();

            if (actType == "signmoid")
            {
                p_tVal.Show();
                p_gVal.Show();
            }
            if (actType == "treapta")
            {
                p_tVal.Show();
            }
            if (actType == "tanh")
            {
                p_tVal.Show();
                p_gVal.Show();
            }
            if (actType == "rampa")
                p_gVal.Show();
        }


        public static double GetActBinaryForRes(string actType, double x, double t, double g)
        {
            if (actType == "signmoid")
                return SigmoidBinary(x, g, t);
            if (actType == "treapta")
                return Treapta(x, t);
            if (actType == "semn")
                return Semn(x);
            if (actType == "tanh")
                return TanHBinary(x, g, t);
            if (actType == "rampa")
                return RampaBinary(x, g);
            return 0;
        }


        #region Rampa
        private static double Rampa(double x, double g)
        {
            if (x >= g) return 1;
            if (x < g * -1) return -1;
            return x / g;
        }
        private static double RampaBinary(double x, double g)
        {
            return ToBinary(Rampa(x, g), -1, 1);
        }
        #endregion

        #region Tanh
        private static double TanH(double x, double g, double t)
        {
            double up = Math.Pow(Math.E, g * (x - t)) - Math.Pow(Math.E, -1 * g * (x - t));
            double down = Math.Pow(Math.E, g * (x - t)) + Math.Pow(Math.E, -1 * g * (x - t));
            return up / down;
        }
        private static double TanHBinary(double x, double g, double t)
        {
            return ToBinary(TanH(x, g, t), -1, 1);
        }
        #endregion

        #region Semn
        private static double Semn(double x)
        {
            return x >= 0 ? 1 : -1;
        }
        #endregion

        #region Treapta
        private static double Treapta(double x, double t)
        {
            return x >= t ? 1 : 0;
        }
        #endregion

        #region Sigmoid
        private static double Sigmoid(double x, double g, double t)
        {
            g = g * -1;
            return 1 / (1 + Math.Pow(Math.E, g * (x - t)));
        }

        private static double SigmoidBinary(double x, double g, double t)
        {
            return ToBinary(Sigmoid(x, g, t), 0, 1);
        }

        private static  double ToBinary(double x, double limLeft, double limRight)
        {
            double mid = (limLeft + limRight) / 2;
            if (x < mid)
                return limLeft;
            else
                return limRight;
        }
        #endregion
    }
}
