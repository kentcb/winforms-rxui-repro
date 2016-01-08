using System.ComponentModel;
using System.Windows.Forms;
using ReactiveUI;

namespace Repro
{
    public class ChildViewDesignable : ReactiveUserControl<ChildVM>
    {
        public ChildViewDesignable()
        {

        }
    }

    public partial class ChildView : ChildViewDesignable
    {
        public ChildView()
        {
            InitializeComponent();
            
            //if (!IsInDesignMode())
            {
                this
                    .WhenActivated(
                        d =>
                        {
                            d(this.Bind(this.ViewModel, x => x.Test, x => x.textBox.Text));
                        });
            }
        }
    }
}