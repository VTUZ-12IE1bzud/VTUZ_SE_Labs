namespace Lab_7.Data.Repository {
    interface IViewRepository {

        void SetDM(DataManager dm);
        void Load();
        void Close();
    }
}
