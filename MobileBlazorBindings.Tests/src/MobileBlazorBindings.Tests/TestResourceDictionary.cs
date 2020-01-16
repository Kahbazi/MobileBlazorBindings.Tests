using System;
using System.Collections;
using System.Collections.Generic;
using XF = Xamarin.Forms;

namespace MobileBlazorBindings.Tests
{
    public class TestResourceDictionary : XF.Internals.IResourceDictionary
    {
        Dictionary<string, object> a = new Dictionary<string, object>();
        public event EventHandler<XF.Internals.ResourcesChangedEventArgs> ValuesChanged;

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return a.GetEnumerator();
        }

        public bool TryGetValue(string key, out object value)
        {
            return a.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return a.GetEnumerator();
        }
    }
}
