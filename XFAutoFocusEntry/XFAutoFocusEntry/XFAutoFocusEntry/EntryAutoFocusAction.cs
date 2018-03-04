using System.Threading.Tasks;
using Behaviors.Base;
using Behaviors.Interface;
using Xamarin.Forms;

namespace XFAutoFocusEntry
{
    /*how to use
     <controls:Entry.Behaviors>
                    <behaviors:EventHandlerBehavior EventName="ReturnRequest">
                        <behaviors:InvokeCommandAction Command="{Binding NextStepCommand}" CommandParameter="-1" />
                    </behaviors:EventHandlerBehavior>
                </controls:Entry.Behaviors>

        <controls:Entry.Behaviors>
                    <behaviors:EventHandlerBehavior EventName="ReturnRequest">
                        <controls:EntryAutoFocusAction TargetObject="{x:Reference EntryUserPhone}" />
                    </behaviors:EventHandlerBehavior>
                </controls:Entry.Behaviors>
         
         */
    public class EntryAutoFocusAction : AnimationBase, IAction
    {
        public Task<bool> Execute(object sender, object parameter)
        {
            Entry element;
            if (TargetObject != null)
            {
                element = TargetObject as Entry;
            }
            else
            {
                element = sender as Entry;
            }

            if (element == null)
            {
                return Task.FromResult(false);
            }

            //auto focus
            element.Focus();

            return Task.FromResult(true);
        }
    }
}