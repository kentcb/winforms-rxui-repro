namespace Repro
{
    using System.ComponentModel;
    using System.Windows.Forms;
    using ReactiveUI;

    public class ReactiveUserControl<TViewModel> : UserControl, IReactiveObject, IViewFor<TViewModel>
        where TViewModel : class
    {
        private TViewModel viewModel;

        public TViewModel ViewModel
        {
            get { return this.viewModel; }
            set { this.RaiseAndSetIfChanged(ref this.viewModel, value); }
        }

        object IViewFor.ViewModel
        {
            get { return this.ViewModel; }
            set { this.ViewModel = (TViewModel)value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event ReactiveUI.PropertyChangingEventHandler PropertyChanging;

        public void RaisePropertyChanged(PropertyChangedEventArgs args) =>
            this.PropertyChanged?.Invoke(this, args);

        public void RaisePropertyChanging(ReactiveUI.PropertyChangingEventArgs args) =>
            this.PropertyChanging?.Invoke(this, args);

        public static bool IsInDesignMode()
        {
            return System.Reflection.Assembly.GetExecutingAssembly()
                 .Location.Contains("VisualStudio");
        }
    }

    public class ReactiveForm<TViewModel> : Form, IReactiveObject, IViewFor<TViewModel>
        where TViewModel : class
    {
        private TViewModel viewModel;

        public TViewModel ViewModel
        {
            get { return this.viewModel; }
            set { this.RaiseAndSetIfChanged(ref this.viewModel, value); }
        }

        object IViewFor.ViewModel
        {
            get { return this.ViewModel; }
            set { this.ViewModel = (TViewModel)value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event ReactiveUI.PropertyChangingEventHandler PropertyChanging;

        public void RaisePropertyChanged(PropertyChangedEventArgs args) =>
            this.PropertyChanged?.Invoke(this, args);

        public void RaisePropertyChanging(ReactiveUI.PropertyChangingEventArgs args) =>
            this.PropertyChanging?.Invoke(this, args);

        public static bool IsInDesignMode()
        {
            return System.Reflection.Assembly.GetExecutingAssembly()
                 .Location.Contains("VisualStudio");
        }
    }

}