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
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM)
        {
            _events = events;
            _salesVM = salesVM;

            _events.Subscribe(this);

            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void ExitApplication()
        {
            TryClose();
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}
