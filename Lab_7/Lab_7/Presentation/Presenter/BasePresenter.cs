public abstract class BasePresenter<TView> : IPresenter where TView : IView {

    protected readonly TView _view;

    public BasePresenter(TView view) {
        _view = view;
    }

    public virtual void Run() {
        _view?.Show();
    }

}
