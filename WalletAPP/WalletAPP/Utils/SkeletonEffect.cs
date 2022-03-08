using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WalletAPP.Utils
{
    public class SkeletonEffect : RoutingEffect
    {
        public SkeletonEffect() : base($"Skeleton.{nameof(SkeletonEffect)}")
        {
        }
    }
}
