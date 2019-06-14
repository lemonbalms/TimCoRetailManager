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
        private readonly SimpleContainer _container;
        private readonly IEventAggregator _events;
        private readonly SalesViewModel _salesVM;

        public ShellViewModel(
            SimpleContainer container, 
            IEventAggregator events, 
            SalesViewModel salesVM)
        {
            _container = container;

            _events = events;
            _events.Subscribe(this);

            _salesVM = salesVM;

            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}
