using Voody.UniLeo.Lite;

namespace Integration
{
    public class ViewComponentProvider : MonoProvider<ViewComponent>
    {
        public ViewComponent Value
        {
            get => value;
            set => this.value = value;
        }
    }
}