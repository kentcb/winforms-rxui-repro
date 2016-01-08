namespace Repro
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive;
    using System.Reactive.Linq;
    using ReactiveUI;

    public sealed class MainVM : ReactiveObject
    {
        private readonly ChildVM child = new ChildVM();

        public ChildVM Child => this.child;
    }

    public sealed class ChildVM : ReactiveObject
    {
        private string test;

        public ChildVM()
        {
            this.test = "testing";
        }

        public string Test
        {
            get { return this.test; }
            set { this.RaiseAndSetIfChanged(ref this.test, value); }
        }
    }
}