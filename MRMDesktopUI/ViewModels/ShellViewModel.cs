using Caliburn.Micro;
using MRMDesktopUI.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        public ShellViewModel(LoginViewModel loginVM, IEventAggregator events, SalesViewModel salesVM)
        {
            _events = events;
            _loginVM = loginVM;
            _salesVM = salesVM;

            _events.Subscribe(this);

            ActivateItem(_loginVM);
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}
