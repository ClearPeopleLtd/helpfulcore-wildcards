﻿using System;

namespace Helpfulcore.Wildcards.Events.PublishEnd
{
    public class WildcardsCachePurgeProcessor
    {
        public void ClearCache(object sender, EventArgs args)
        {
            try
            {
                WildcardManager.Current.ClearCache();
            }
            catch
            {
                //
            }
        }
    }
}
