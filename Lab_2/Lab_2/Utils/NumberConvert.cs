namespace Lab_2.Utils {
    class NumberConvert {

        public static bool ValidateStr2Float(string number) {
            try {
                Str2Float(number);
            } catch {
                return false;
            }
            return true;
        }

        public static float Str2Float(string number) {
            return float.Parse(number);
        }

    }
}
