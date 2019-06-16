using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUI.Library.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel:Conductor<Object>, IHandle<LogOnEvent>
    {
        private readonly IEventAggregator _events;
        private readonly SalesViewModel _salesVM;

        public ShellViewModel(
            IEventAggregator events, 
            SalesViewModel salesVM)
        {

            _events = events;
            _events.Subscribe(this);

            _salesVM = salesVM;

            // ActivateItem(_container.GetInstance<LoginViewModel>());
            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}
