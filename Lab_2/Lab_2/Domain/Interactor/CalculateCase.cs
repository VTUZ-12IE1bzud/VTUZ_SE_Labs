
using System;

namespace Lab_2.Domain.Interactor {
    class CalculateCase {

        public event Handler OnEvent;

        public delegate void Handler(object sender, CalculateEventArgs e);
      
        public enum State { SUCCESS, ERROR }

        public class CalculateEventArgs : EventArgs {
            public State State;
            public float Summa;
        }

        public void Run(string paramA, string paramB) {
            if (OnEvent == null) {
                return;
            }
            bool validateParamA = Utils.NumberConvert.ValidateStr2Float(paramA);
            bool validateParamB = Utils.NumberConvert.ValidateStr2Float(paramB);
            if (validateParamA && validateParamB) {
                float fParamA = Utils.NumberConvert.Str2Float(paramA);
                float fParamB = Utils.NumberConvert.Str2Float(paramB);
                float summa = (fParamA / 3) - fParamB;
                CalculateEventArgs args = new CalculateEventArgs();
                args.State = State.SUCCESS;
                args.Summa = summa;
                OnEvent(this, args);
            } else {
                CalculateEventArgs args = new CalculateEventArgs();
                args.State = State.ERROR;
                OnEvent(this, args);
            }
        }

    }
}
