using ReactiveUI;

namespace Repro
{
    public class Form1Designable : ReactiveForm<MainVM>
    {
        private ChildViewDesignable childView;

        private void InitializeComponent()
        {
            this.childView = new Repro.ChildViewDesignable();
            this.SuspendLayout();
            // 
            // childView
            // 
            this.childView.Location = new System.Drawing.Point(12, 12);
            this.childView.Name = "childView";
            this.childView.Size = new System.Drawing.Size(260, 237);
            this.childView.TabIndex = 0;
            this.childView.ViewModel = null;
            // 
            // Form1Designable
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.childView);
            this.Name = "Form1Designable";
            this.ResumeLayout(false);

        }
    }

    public partial class Form1 : Form1Designable
    {
        public Form1()
        {
            InitializeComponent();

            this.ViewModel = new MainVM();

            this
                .WhenActivated(
                    d =>
                    {
                        d(this.OneWayBind(this.ViewModel, x => x.Child, x => x.childView.ViewModel));
                    });
        }
    }
}
