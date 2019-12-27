using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSL.Gestures.Segments
{
    using KSL.Gestures.Core;
    using Microsoft.Kinect;
    public class TrailGesture : IGesturesSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            
            
            if (skeleton.Joints[JointType.WristLeft].Position.X > skeleton.Joints[JointType.HipLeft].Position.X &&
                skeleton.Joints[JointType.WristRight].Position.X < skeleton.Joints[JointType.HipRight].Position.X)
            {
                if (skeleton.Joints[JointType.WristLeft].Position.Y < skeleton.Joints[JointType.Spine].Position.Y &&
                    skeleton.Joints[JointType.WristRight].Position.Y < skeleton.Joints[JointType.Spine].Position.Y)
                {
                    return GesturePartResult.Succeed;
                }

                return GesturePartResult.Pausing;
            }

            return GesturePartResult.Fail;
            
/*

            if (skeleton.Joints[JointType.AnkleRight].Position.Y > skeleton.Joints[JointType.AnkleLeft].Position.Y)
            {
                Console.Write("NEW GESTURE#############################################33s\n");
                if (skeleton.Joints[JointType.KneeRight].Position.Y> skeleton.Joints[JointType.HipRight].Position.Y)
                {
                    return GesturePartResult.Succeed;
                }
                return GesturePartResult.Pausing;

            }
            return GesturePartResult.Fail;*/
        }
    }
}
