namespace Lab_7.Utils {
    class FilterUtils {

        private static readonly string EMPLOYEE_SURNAME = "surname";
        private static readonly string EMPLOYEE_NAME = "name";
        private static readonly string EMPLOYEE_PATRONYMIC = "patronymic";

        public static string Bulder(string surname, string name, string patronymic) {
            string whereStatement = "";

            if (!string.IsNullOrEmpty(surname)) {
                string whereConcatenator = string.Format("{0} LIKE '{1}%'",
                    EMPLOYEE_SURNAME,
                    surname);
                if (whereStatement.Length == 0) {
                    whereStatement += string.Format("{0}", whereConcatenator);
                } else {
                    whereStatement += string.Format(" AND {0}", whereConcatenator);
                }
            }

            if (!string.IsNullOrEmpty(name)) {
                string whereConcatenator = string.Format("{0} LIKE '{1}%'",
                    EMPLOYEE_NAME,
                    name);
                if (whereStatement.Length == 0) {
                    whereStatement = string.Format("{0}", whereConcatenator);
                } else {
                    whereStatement += string.Format(" AND {0}", whereConcatenator);
                }
            }

            if (!string.IsNullOrEmpty(patronymic)) {
                string whereConcatenator = string.Format("{0} LIKE '{1}%'",
                    EMPLOYEE_PATRONYMIC,
                    patronymic);
                if (whereStatement.Length == 0) {
                    whereStatement = string.Format("{0}", whereConcatenator);
                } else {
                    whereStatement += string.Format(" AND {0}", whereConcatenator);
                }
            }
            return whereStatement.Length > 0 ? whereStatement : null;
        }

    }
}
