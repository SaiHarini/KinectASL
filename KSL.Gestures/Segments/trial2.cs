using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSL.Gestures.Segments
{
    using KSL.Gestures.Core;
    using Microsoft.Kinect;
    public class trial2 : IGesturesSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {

                        if (skeleton.Joints[JointType.AnkleRight].Position.Y > skeleton.Joints[JointType.AnkleLeft].Position.Y)
                        {
                            Console.Write("NEW GESTURE#############################################33s\n");
                            if (skeleton.Joints[JointType.KneeRight].Position.Y> skeleton.Joints[JointType.HipRight].Position.Y)
                            {
                                return GesturePartResult.Succeed;
                            }
                            return GesturePartResult.Pausing;

                        }
                        return GesturePartResult.Fail;
        }
    }
}
